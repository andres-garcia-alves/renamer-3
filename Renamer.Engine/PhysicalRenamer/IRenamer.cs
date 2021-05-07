using System.Threading.Tasks;

namespace Renamer.Engine.PhysicalRenamer
{
    internal interface IRenamer
    {
        Task<bool> Rename(ObjectType objectType, string currentName, string newName);
    }
}
