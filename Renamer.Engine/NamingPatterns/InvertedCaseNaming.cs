using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

using Renamer.Engine.Entities;
using Renamer.Engine.PhysicalRenamer;

namespace Renamer.Engine.NamingPatterns
{
    /// <summary>
    /// Inverted-Case naming.
    /// Eg: 'Abc def' -> 'aBC DEF'
    /// </summary>
    public sealed class InvertedCaseNaming : BaseNaming
    {
        public InvertedCaseNaming(IRenamer renamer, RenameSettings renameSettings) : base(renamer, renameSettings) { }

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
            string str;
            char[] characters;
            StringBuilder sb = new StringBuilder();

            if (base.RenameSettings.IncludeExtension && Path.GetExtension(currentName) != String.Empty)
            {
                characters = Path.GetFileName(currentName).ToCharArray();

                foreach (char c in characters)
                {
                    if (c == Char.ToUpper(c)) sb.Append(Char.ToLower(c));
                    else sb.Append(Char.ToUpper(c));
                }

                str = sb.ToString();
            }
            else
            {
                characters = Path.GetFileNameWithoutExtension(currentName).ToCharArray();

                foreach (char c in characters)
                {
                    if (c == Char.ToUpper(c)) sb.Append(Char.ToLower(c));
                    else sb.Append(Char.ToUpper(c));
                }

                str = sb.ToString() + Path.GetExtension(currentName);
            }

            string basePath = Path.GetDirectoryName(currentName);
            return Path.Combine(basePath, str);
        }
    }
}
