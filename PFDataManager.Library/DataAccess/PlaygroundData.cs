using MongoDB.Driver;
using PFDataManager.Library.Internal.DataAccess;
using PFDataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFDataManager.Library.DataAccess
{
    public class PlaygroundData
    {
        public List<PlaygroundModel> GetAll()
        {
            //TODO: Change to DI
            MongoDataAccess client = new MongoDataAccess();
            var database = client.GetDatabase("test");
            List<PlaygroundModel> playgrounds = database.GetCollection<PlaygroundModel>("playgrounds").FindSync(FilterDefinition<PlaygroundModel>.Empty).ToList();
            return playgrounds;
        }

        public async Task<List<PlaygroundModel>> FilterPlaygroundsByAgeAsync(string age)
        {
            //TODO: Change to DI
            MongoDataAccess client = new MongoDataAccess();
            var database = client.GetDatabase("test");

            var filter = Builders<PlaygroundModel>.Filter.Eq("age",age);

            List<PlaygroundModel> playgrounds = await database.GetCollection<PlaygroundModel>("playgrounds").Find(filter).ToListAsync();

            return playgrounds;
        }

        public async Task<List<PlaygroundModel>> FilterPlaygroundsByQuadrantAsync(string quadrant)
        {
            //TODO: Change to DI
            MongoDataAccess client = new MongoDataAccess();
            var database = client.GetDatabase("test");

            var filter = Builders<PlaygroundModel>.Filter.Eq("quadrant", quadrant);

            List<PlaygroundModel> playgrounds = await database.GetCollection<PlaygroundModel>("playgrounds").Find(filter).ToListAsync();

            return playgrounds;

        }

        public async Task<List<PlaygroundModel>> FilterPlaygroundsByGroundCoverAsync(string groundCover)
        {
            //TODO: Change to DI
            MongoDataAccess client = new MongoDataAccess();
            var database = client.GetDatabase("test");

            var filter = Builders<PlaygroundModel>.Filter.Eq("ground_cover", groundCover);

            List<PlaygroundModel> playgrounds = await database.GetCollection<PlaygroundModel>("playgrounds").Find(filter).ToListAsync();

            return playgrounds;
        }

        public async Task<List<PlaygroundModel>> FilterPlaygroundsBySizeAsync(string size)
        {
            //TODO: Change to DI
            MongoDataAccess client = new MongoDataAccess();
            var database = client.GetDatabase("test");

            var filter = Builders<PlaygroundModel>.Filter.Eq("size", size);

            List<PlaygroundModel> playgrounds = await database.GetCollection<PlaygroundModel>("playgrounds").Find(filter).ToListAsync();

            return playgrounds;
        }


        public async Task<List<PlaygroundModel>> FilterPlaygroundsByAccessibilityAsync(string accessibility)
        {
            //TODO: Change to DI
            MongoDataAccess client = new MongoDataAccess();
            var database = client.GetDatabase("test");

            var filter = Builders<PlaygroundModel>.Filter.Eq("accessibility", accessibility);

            List<PlaygroundModel> playgrounds = await database.GetCollection<PlaygroundModel>("playgrounds").Find(filter).ToListAsync();

            return playgrounds;
        }

        public async Task<List<PlaygroundModel>> FilterPlaygroundsByMultipleAsync(IDictionary<string,string> criteria)
        {
            //TODO: Change to DI
            MongoDataAccess client = new MongoDataAccess();
            var database = client.GetDatabase("test");

            List<FilterDefinition<PlaygroundModel>> filterList = new List<FilterDefinition<PlaygroundModel>>();

            foreach (var pair in criteria)
            {
                var stringField = new StringFieldDefinition<PlaygroundModel, string>(pair.Key);
                var filter = Builders<PlaygroundModel>.Filter.Eq(stringField, pair.Value);
                filterList.Add(filter);
            }

            var compiledFilters = Builders<PlaygroundModel>.Filter.And(filterList);

            List<PlaygroundModel> playgrounds = await database.GetCollection<PlaygroundModel>("playgrounds").Find(compiledFilters).ToListAsync();

            return playgrounds;
        }
    }
}
