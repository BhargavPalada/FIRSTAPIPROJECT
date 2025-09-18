using First.API.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System.Collections.Generic;

namespace First.API.Services
{
    public class GameServices
    {
        private readonly IMongoCollection<Games> _games;

        public GameServices(IOptions<GamesDBSettings> settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.Value.DatabaseName);
            _games = database.GetCollection<Games>(settings.Value.GamesCollectionName);
        }

        public Games Create(Games game)
        {
            _games.InsertOne(game);
            return game;
        }

        public List<Games> Get()
        {
            return _games.Find(game => true).ToList();
        }

        public Games Get(string id)
        {
            return _games.Find<Games>(game => game.Id == id).FirstOrDefault();
        }

        public void Remove(string id)
        {
            _games.DeleteOne(game => game.Id == id);
        }

        public void Update(string id, Games game)
        {
            _games.ReplaceOne(g => g.Id == id, game);
        }
    }
}
