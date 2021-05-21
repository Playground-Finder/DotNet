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
    public class UserData
    {
        public UserModel GetUserById(string id)
        {
            MongoDataAccess client = new MongoDataAccess();
            var database = client.GetDatabase("test");
            UserModel user = database.GetCollection<UserModel>("users").FindSync(Builders<UserModel>.Filter.Eq("_id", id)).First();
            return user;
        }
    }
}
