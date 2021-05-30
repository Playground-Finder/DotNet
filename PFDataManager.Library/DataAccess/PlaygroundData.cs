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
    }
}
