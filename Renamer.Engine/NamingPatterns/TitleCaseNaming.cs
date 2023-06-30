using Renamer.Engine.Entities;
using Renamer.Engine.PhysicalRenamer;

namespace Renamer.Engine.NamingPatterns
{
    /// <summary>
    /// Title-Case naming.
    /// Eg: 'abc def' -> 'Abc Def'
    /// </summary>
    public sealed class TitleCaseNaming : BaseNaming
    {
        public TitleCaseNaming(IRenamer renamer, RenameSettings renameSettings) : base(renamer, renameSettings) { }

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
            string str = "", firstChar, remainingChars;
            string[] words;

            words = Path.GetFileNameWithoutExtension(currentName).Split(new string[] { " " }, StringSplitOptions.None);

            // capitalize each word
            foreach (string word in words)
            {
                firstChar = remainingChars = "";

                if (word.Length > 0)
                {
                    firstChar = word.Substring(0, 1);
                    remainingChars = word.Substring(1);
                }

                str += firstChar.ToUpper() + remainingChars.ToLower() + " ";
            }

            // delete the last black space
            str = str.Remove(str.Length - 1);

            // process file extension
            if (base.RenameSettings.IncludeExtension && Path.GetExtension(currentName) != String.Empty)
            {
                firstChar = Path.GetExtension(currentName).Substring(1, 1);
                remainingChars = Path.GetExtension(currentName).Substring(2);
                str += "." + firstChar.ToUpper() + remainingChars.ToLower();

            }
            else
            {
                str += Path.GetExtension(currentName);
            }

            string basePath = Path.GetDirectoryName(currentName) ?? "";
            return Path.Combine(basePath, str);
        }
    }
}
