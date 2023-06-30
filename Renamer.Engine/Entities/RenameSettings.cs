namespace Renamer.Engine.Entities
{
    public class RenameSettings
    {
        public RenameType RenameType { get; }
        public List<string> Parameters { get; }
        public bool IncludeExtension { get; }

        public RenameSettings(RenameType renameType) : this(renameType, new List<string>(), default)
        {
        }

        public RenameSettings(RenameType renameType, List<string> parameters, bool includeExtension = false)
        {
            // if (parameters == null) { throw new ArgumentNullException(nameof(parameters)); }

            this.RenameType = renameType;
            this.Parameters = parameters;
            this.IncludeExtension = includeExtension;
        }
    }
}
