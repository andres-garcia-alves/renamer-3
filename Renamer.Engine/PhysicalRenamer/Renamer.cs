using System;
using System.IO;
using System.Threading.Tasks;

namespace Renamer.Engine.PhysicalRenamer
{
    internal sealed class Renamer : IRenamer
    {
        /// <summary>
        /// Makes the physical rename of file/directory
        /// </summary>
        /// <param name="objectType">Object type: file/directory</param>
        /// <param name="currentName">Current object full path</param>
        /// <param name="newName">New object full path</param>
        /// <returns>Return true if any charge was made to physical object</returns>
        public Task<bool> Rename(ObjectType objectType, string currentName, string newName)
        {
            try
            {
                bool validation = Validations(objectType, currentName, newName);
                if (!validation) { return Task.FromResult<bool>(false); }

                // actual rename
                if (objectType == ObjectType.File)
                {
                    var fi = new FileInfo(currentName);
                    fi.MoveTo(newName);
                }
                else if (objectType == ObjectType.Directory)
                {
                    string guid = Guid.NewGuid().ToString();
                    Directory.Move(currentName, guid);
                    Directory.Move(guid, newName);
                }

                return Task.FromResult<bool>(true);
            }
            catch (Exception) { return Task.FromResult<bool>(false); }
        }

        private static bool Validations(ObjectType objectType, string currentName, string newName)
        {
            if (objectType == ObjectType.Unknown) { return false; }
            // throw new ArgumentException($"Unknown object type to rename.");

            if (currentName == newName) { return false; }
            // throw new ArgumentException($"CurrentName & NewName are the same.", nameof(currentName));

            return true;
        }
    }
}
