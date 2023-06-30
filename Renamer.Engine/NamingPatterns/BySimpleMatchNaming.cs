using System;
using System.IO;
using System.Threading.Tasks;

using Renamer.Engine.Entities;
using Renamer.Engine.PhysicalRenamer;

namespace Renamer.Engine.NamingPatterns
{
    /// <summary>
    /// Simple-Matching naming.
    /// Eg: match = 'def', replace = 'YZ': 'abc def' -> 'abc YZ'
    /// </summary>
    public sealed class BySimpleMatchNaming : BaseNaming
    {
        public BySimpleMatchNaming(IRenamer renamer, RenameSettings renameSettings) : base(renamer, renameSettings) { }

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
                str = Path.GetFileName(currentName).Replace(base.RenameSettings.Parameters[0], base.RenameSettings.Parameters[1]);
            }
            else
            {
                str = Path.GetFileNameWithoutExtension(currentName).Replace(base.RenameSettings.Parameters[0], base.RenameSettings.Parameters[1]);
                str += Path.GetExtension(currentName);
            }

            string basePath = Path.GetDirectoryName(currentName);
            return Path.Combine(basePath, str);
        }
    }
}
