namespace Renamer.Engine.PhysicalRenamer
{
    public interface IRenamer
    {
        Task<bool> Rename(ObjectType objectType, string currentName, string newName);
    }
}
