using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFDataManager.Library.Internal.DataAccess
{
    //TODO: May need to clean up before closing the application. 
    //TODO: Investigate DI to allow for Unit Testing. 
    //TODO: Set up as a singleton so only a single client exists. 
    internal  class MongoDataAccess
    {
        private MongoClient _client;

        public MongoDataAccess()
        {
            InitializeClient();
        }

        private void InitializeClient()
        {
            if (_client == null)
            {
                var connectionString = ConfigurationManager.ConnectionStrings["mongo"].ConnectionString;
                _client = new MongoClient(connectionString);
            }
        }

        public IMongoDatabase GetDatabase(string name)
        {
            var database = _client.GetDatabase(name);
            return database;
        }


    }
}
