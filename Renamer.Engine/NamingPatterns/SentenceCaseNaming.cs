using System;
using System.IO;
using System.Threading.Tasks;

using Renamer.Engine.Entities;
using Renamer.Engine.PhysicalRenamer;

namespace Renamer.Engine.NamingPatterns
{
    /// <summary>
    /// Sentence-Case naming.
    /// Eg: 'abc def' -> 'Abc def'
    /// </summary>
    public sealed class SentenceCaseNaming : BaseNaming
    {
        public SentenceCaseNaming(IRenamer renamer, RenameSettings renameSettings) : base(renamer, renameSettings) { }

        public override async Task<NamingResult> Execute(ObjectType objectType, string currentName)
        {
            var newName = this.Process(objectType, currentName);
            var result = await base.PhysicalRenamer.Rename(objectType, currentName, newName);

            return new NamingResult(result, objectType, currentName, newName);
        }

        public override NamingResult Preview(ObjectType objectType, string currentName)
        {
            var newName = this.Process(objectType, currentName);

            return new NamingResult(false, objectType, currentName, newName);
        }

        protected override string Process(ObjectType objectType, string currentName)
        {
            string str, firstChar, remainingChars;

            if (base.RenameSettings.IncludeExtension && Path.GetExtension(currentName) != String.Empty)
            {
                firstChar = Path.GetFileNameWithoutExtension(currentName).Substring(0, 1);
                remainingChars = Path.GetFileNameWithoutExtension(currentName).Substring(1);
                str = firstChar.ToUpper() + remainingChars.ToLower();

                firstChar = Path.GetExtension(currentName).Substring(1, 1);
                remainingChars = Path.GetExtension(currentName).Substring(2);
                str += "." + firstChar.ToUpper() + remainingChars.ToLower();

            }
            else
            {
                firstChar = Path.GetFileName(currentName).Substring(0, 1);
                remainingChars = Path.GetFileName(currentName).Substring(1);
                str = firstChar.ToUpper() + remainingChars.ToLower();
            }

            string basePath = Path.GetDirectoryName(currentName);
            return Path.Combine(basePath, str);
        }
    }
}
