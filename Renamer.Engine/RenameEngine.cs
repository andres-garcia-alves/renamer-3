using Renamer.Engine.Entities;
using Renamer.Engine.NamingPatterns;
using Renamer.Engine.PhysicalRenamer;

namespace Renamer.Engine
{
    public class RenameEngine
    {
        private readonly RenameSettings renameSettings;
        private readonly IRenamer renamer;

        public event EventHandler<NamingProcessedEventArgs>? NamingProcessed;
        public delegate void NamingProcessedEventHandler(object sender, NamingProcessedEventArgs e);

        public RenameEngine(RenameSettings renameSettings) : this(renameSettings, null)
        {
        }

        public RenameEngine(RenameSettings renameSettings, EventHandler<NamingProcessedEventArgs>? namingProcessed)
        {
            this.renameSettings = renameSettings;
            this.renamer = new PhysicalRenamer.Renamer();

            this.NamingProcessed += namingProcessed;
        }

        /// <summary>
        /// Previews NamingRequests files according to RenameSettings profile.
        /// </summary>
        /// <param name="namingRequests">List of requested objets to rename.</param>
        /// <returns>Returns a collection of NamingResult, one for each input NamingRequest.</returns>
        public List<NamingResult> Preview(List<NamingRequest> namingRequests)
        {
            try
            {
                var namingResults = new List<NamingResult>();
                new RenameEngineValidator(this.renameSettings.RenameType, this.renameSettings.Parameters, namingRequests).Validate();

                BaseNaming naming = this.GetNamingPattern(this.renamer, this.renameSettings);

                foreach (var namingRequest in namingRequests)
                {
                    NamingResult namingResult = naming.Preview(namingRequest.ObjectType, namingRequest.CurrentName);
                    namingResults.Add(namingResult);
                }

                return namingResults;
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Renames NamingRequests files according to RenameSettings profile.
        /// </summary>
        /// <param name="namingRequests">List of requested objets to rename.</param>
        /// <returns>Returns a collection of NamingResult, one for each input NamingRequest.</returns>
        public async Task<List<NamingResult>> Rename(List<NamingRequest> namingRequests)
        {
            try
            {
                var count = 1;
                var namingResults = new List<NamingResult>();
                new RenameEngineValidator(this.renameSettings.RenameType, this.renameSettings.Parameters, namingRequests).Validate();

                BaseNaming naming = this.GetNamingPattern(this.renamer, this.renameSettings);

                foreach (var namingRequest in namingRequests)
                {
                    NamingResult namingResult = await naming.Execute(namingRequest.ObjectType, namingRequest.CurrentName);

                    var eventArgs = new NamingProcessedEventArgs(Operation.Rename, namingResult, count++ * 100 / namingRequests.Count);
                    this.OnNamingProcessed(eventArgs);

                    namingResults.Add(namingResult);
                }

                return namingResults;
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Reverts a previous renaming operation based on its generated NamingResults.
        /// </summary>
        /// <param name="prevNamingResults">NamingResults of the rename operation to revert.</param>
        /// <returns>Returns a collection of NamingResult, one for each input NamingResult.</returns>
        public async Task<List<NamingResult>> Undo(List<NamingResult> prevNamingResults)
        {
            try
            {
                var count = 1;
                var namingResults = new List<NamingResult>();
                IRenamer renamer = new PhysicalRenamer.Renamer();

                prevNamingResults = prevNamingResults.Where(a => a.Success).ToList();

                foreach (var prevNamingResult in prevNamingResults)
                {
                    bool result = await renamer.Rename(prevNamingResult.ObjectType, prevNamingResult.NewName, prevNamingResult.OldName);
                    var namingResult = new NamingResult(result, prevNamingResult.ObjectType, prevNamingResult.NewName, prevNamingResult.OldName);

                    var eventArgs = new NamingProcessedEventArgs(Operation.Undo, namingResult, count++ * 100 / prevNamingResults.Count);
                    this.OnNamingProcessed(eventArgs);

                    namingResults.Add(namingResult);
                }

                return namingResults;
            }
            catch (Exception) { throw; }
        }

        protected virtual void OnNamingProcessed(NamingProcessedEventArgs e)
        {
            this.NamingProcessed?.Invoke(this, e);
        }

        private BaseNaming GetNamingPattern(IRenamer renamer, RenameSettings renameSettings)
        {
            switch (this.renameSettings.RenameType)
            {
                case RenameType.SentenceCase:
                    return new SentenceCaseNaming(renamer, renameSettings);
                case RenameType.TitleCase:
                    return new TitleCaseNaming(renamer, renameSettings);
                case RenameType.UpperCase:
                    return new UpperCaseNaming(renamer, renameSettings);
                case RenameType.LowerCase:
                    return new LowerCaseNaming(renamer, renameSettings);
                case RenameType.InvertedCase:
                    return new InvertedCaseNaming(renamer, renameSettings);
                case RenameType.BySimpleMatch:
                    return new BySimpleMatchNaming(renamer, renameSettings);
                case RenameType.ByPattern:
                    return new ByPatternNaming(renamer, renameSettings);
                case RenameType.PositionalReplace:
                    return new PositionalReplaceNaming(renamer, renameSettings);
                case RenameType.PositionalAppend:
                    return new PositionalAppendNaming(renamer, renameSettings);
                case RenameType.RemoveTildes:
                    return new RemoveTildesNaming(renamer, renameSettings);
                default:
                    throw new ApplicationException("Unknown rename method.");
            }
        }
    }
}
