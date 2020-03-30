namespace Movie.Domain.Images
{
    public class Images
    {
        public Images(int id, string path, int entityId, string entityName)
        {
            Id = id;
            Path = path;
            EntityId = entityId;
            EntityName = entityName;
        }

        public int Id { get; private set; }
        public string Path { get; private set; }
        public int EntityId { get; private set; }
        public string EntityName { get; private set; }
    }
}
