using MongoDB.Bson;
using MongoDB.Driver;
using Portfolio.Business.Models;
using Sitecore.FakeDb;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Business.DataAccess
{
   
    public class MongoCrud
    {
        public IMongoDatabase db { get; set; }
        private string database;
        public MongoCrud(IDatabaseSettings databaseSettings)
        {
            MongoClient client;
            if (String.IsNullOrEmpty(databaseSettings.ConnectionString))
            {
                //empty conntection for localhost 
                client = new MongoClient();
            }
            else
            {
                //live atlas config
                client = new MongoClient(databaseSettings.ConnectionString);
            }

            db = client.GetDatabase(databaseSettings.DatabaseName);
        }



        public void Create<T>(string table, T record)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);
        }

        public List<T> Read<T>(string table)
        {
            var collection = db.GetCollection<T>(table);
            return collection.Find(new BsonDocument()).ToList();
        }

        public T ReadById<T>(string table, Guid id)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);
            return collection.Find(filter).First();
        }

        public void Upsert<T>(string table, Guid id, T record) {
            var collection = db.GetCollection<T>(table);
            ReplaceOptions replaceOptions = new ReplaceOptions { IsUpsert = true };
            var result = collection.ReplaceOne(
                         new BsonDocument("id", id), 
                         record,
                         replaceOptions);

        }
    }
}
