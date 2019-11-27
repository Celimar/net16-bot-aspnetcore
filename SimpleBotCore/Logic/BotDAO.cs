using Microsoft.IdentityModel.Protocols;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBotCore.Logic
{
    public class BotDAO
    {
        public void connection(SimpleMessage message)
        {
            string connectionString = ConfigurationManager.AppSettings["connectionMongo"];

            var cliente = new MongoClient(connectionString);

            var db = cliente.GetDatabase("net16");
            var col = db.GetCollection<BsonDocument>("col01");
                                    
            var doc = new BsonDocument()
            {
                { "id", message.Id},
                { "nome", message.User},
                { "text", message.Text}
            };

            col.InsertOne(doc);

        }

    }
}
