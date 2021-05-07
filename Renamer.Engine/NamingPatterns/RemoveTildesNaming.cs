using System;
using System.IO;
using System.Threading.Tasks;

using Renamer.Engine.Entities;
using Renamer.Engine.PhysicalRenamer;

namespace Renamer.Engine.NamingPatterns
{
    /// <summary>
    /// Tilde-Remove naming.
    /// Eg: 'Áéíóú' -> 'Aeiou'
    /// </summary>
    internal sealed class RemoveTildesNaming : BaseNaming
    {
        public RemoveTildesNaming(IRenamer renamer, RenameSettings renameSettings) : base(renamer, renameSettings) { }

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
                str = Path.GetFileName(currentName)
                    .Replace("á", "a").Replace("é", "e").Replace("í", "i").Replace("ó", "o").Replace("ú", "u")
                    .Replace("Á", "A").Replace("É", "E").Replace("Í", "I").Replace("Ó", "O").Replace("Ú", "U");
            }
            else
            {
                str = Path.GetFileNameWithoutExtension(currentName)
                    .Replace("á", "a").Replace("é", "e").Replace("í", "i").Replace("ó", "o").Replace("ú", "u")
                    .Replace("Á", "A").Replace("É", "E").Replace("Í", "I").Replace("Ó", "O").Replace("Ú", "U");
                str += Path.GetExtension(currentName);
            }

            string basePath = Path.GetDirectoryName(currentName);
            return Path.Combine(basePath, str);
        }
    }
}
