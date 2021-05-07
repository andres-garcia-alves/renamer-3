namespace Renamer.Engine.Entities
{
    public class NamingRequest
    {
        public ObjectType ObjectType { get; }
        public string CurrentName { get; }

        public NamingRequest() { }

        public NamingRequest(ObjectType objectType, string currentName)
        {
            this.ObjectType = objectType;
            this.CurrentName = currentName;
        }
    }
}
