using System;
using System.IO;
using System.Threading.Tasks;

using Renamer.Engine.Entities;
using Renamer.Engine.PhysicalRenamer;

namespace Renamer.Engine.NamingPatterns
{
    /// <summary>
    /// Positional Append naming.
    /// Eg: pos 3 = 'Z': 'abc def' -> 'AbZc def'
    /// </summary>
    internal sealed class PositionalAppendNaming : BaseNaming
    {
        public PositionalAppendNaming(IRenamer renamer, RenameSettings renameSettings) : base(renamer, renameSettings) { }

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

            if (base.RenameSettings.IncludeExtension && Path.GetExtension(currentName) != String.Empty)
            {
                if (Path.GetFileName(currentName).Length >= Convert.ToInt32(base.RenameSettings.Parameters[0])) // check object name-lenght
                {
                    str = Path.GetFileName(currentName).Substring(0, Convert.ToInt32(base.RenameSettings.Parameters[0]) - 1);
                    str += base.RenameSettings.Parameters[1]; // appended text
                    str += Path.GetFileName(currentName).Substring(Convert.ToInt32(base.RenameSettings.Parameters[0]) - 1);
                }
                else // to make no-changes
                {
                    str = Path.GetFileName(currentName);
                }
            }
            else
            {
                if (Path.GetFileNameWithoutExtension(currentName).Length >= Convert.ToInt32(base.RenameSettings.Parameters[0])) // check object name-lenght
                {
                    str = Path.GetFileNameWithoutExtension(currentName).Substring(0, Convert.ToInt32(base.RenameSettings.Parameters[0]) - 1);
                    str += base.RenameSettings.Parameters[1]; // appended text
                    str += Path.GetFileName(currentName).Substring(Convert.ToInt32(base.RenameSettings.Parameters[0]) - 1);
                }
                else // to make no-changes
                {
                    str = Path.GetFileName(currentName);
                }
            }

            string basePath = Path.GetDirectoryName(currentName);
            return Path.Combine(basePath, str);
        }
    }
}
