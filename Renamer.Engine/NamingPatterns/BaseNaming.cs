using System.Threading.Tasks;

using Renamer.Engine.Entities;
using Renamer.Engine.PhysicalRenamer;

namespace Renamer.Engine.NamingPatterns
{
    public abstract class BaseNaming
    {
        protected IRenamer PhysicalRenamer { get; }
        protected RenameSettings RenameSettings { get; }

        public BaseNaming(IRenamer renamer, RenameSettings renameSettings)
        {
            this.PhysicalRenamer = renamer;
            this.RenameSettings = renameSettings;
        }

        public abstract Task<NamingResult> Execute(ObjectType objectType, string currentName);

        public abstract NamingResult Preview(ObjectType objectType, string currentName);

        protected abstract string Process(ObjectType objectType, string currentName);
    }
}
