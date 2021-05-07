namespace Renamer.Engine.Entities
{
    public sealed class NamingResult
    {
        public NamingResult(bool success, ObjectType objectType, string oldName)
            : this(success, objectType, oldName, "") { }

        public NamingResult(bool success, ObjectType objectType, string oldName, string newName)
        {
            this.Success = success;
            this.ObjectType = objectType;
            this.OldName = oldName;
            this.NewName = newName;
        }

        public bool Success { get; set; }
        public ObjectType ObjectType { get; set; }
        public string OldName { get; set; }
        public string NewName { get; set; }
    }
}
