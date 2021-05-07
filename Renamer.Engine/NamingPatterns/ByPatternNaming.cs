using System;
using System.IO;
using System.Threading.Tasks;

using Renamer.Engine.Entities;
using Renamer.Engine.PhysicalRenamer;

namespace Renamer.Engine.NamingPatterns
{
    /// <summary>
    /// Pattern matching naming.
    /// Eg: 'beginnig with text = 'Photo ', Start = '1', Increment = '2', Pad = '4' -> 'Photo 0001', 'Photo 0003', 'Photo 0005', ...'
    /// </summary>
    internal sealed class ByPatternNaming : BaseNaming
    {
        static int currentIndex = int.MinValue;

        public ByPatternNaming(IRenamer renamer, RenameSettings renameSettings) : base(renamer, renameSettings) { }

        public override async Task<NamingResult> Execute(ObjectType objectType, string currentName)
        {
            if (objectType == ObjectType.Directory) // only files allowed, avoid processing directories
                return new NamingResult(false, objectType, currentName);

            var newName = this.Process(objectType, currentName);
            var result = await base.PhysicalRenamer.Rename(objectType, currentName, newName);

            return new NamingResult(result, objectType, currentName, newName);
        }

        public override NamingResult Preview(ObjectType objectType, string currentName)
        {
            if (objectType == ObjectType.Directory) // only files allowed, avoid processing directories
                return new NamingResult(false, objectType, currentName);

            var newName = this.Process(objectType, currentName);

            return new NamingResult(false, objectType, currentName, newName);
        }

        protected override string Process(ObjectType objectType, string currentName)
        {
            string baseName = Convert.ToString(base.RenameSettings.Parameters[0]);
            int startingIndex = Convert.ToInt32(base.RenameSettings.Parameters[1]);
            int increment = Convert.ToInt32(base.RenameSettings.Parameters[2]);
            int numericPad = Convert.ToInt32(base.RenameSettings.Parameters[3]);

            // set currentIndex only the first time
            if (currentIndex == int.MinValue)
                currentIndex = startingIndex;

            // filename
            string str = baseName + Convert.ToString(currentIndex).PadLeft(numericPad, '0') + Path.GetExtension(currentName);

            // increase currentIndex for next time
            currentIndex += increment;

            string basePath = Path.GetDirectoryName(currentName);
            return Path.Combine(basePath, str);
        }
    }
}
