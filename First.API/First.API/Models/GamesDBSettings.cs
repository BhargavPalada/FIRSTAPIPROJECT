namespace First.API.Models
{
    public class GamesDBSettings
    {
        public string GamesCollectionName { get; set; } = null!;
        public string ConnectionString { get; set; } = null!;
        public string DatabaseName { get; set; } = null!;
    }
}
