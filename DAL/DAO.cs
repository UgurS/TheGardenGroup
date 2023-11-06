using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using Model;
using MongoDB.Bson.Serialization;
using System;

namespace DAL
{
    public class DAO
    {
        protected MongoClient client;
        protected IMongoDatabase database;
        public DAO()
        {
            client = new MongoClient("mongodb+srv://thegardengroup:ATPwszhhodqQ8Upi@cluster0.w8hjrzc.mongodb.net/");
        }

        public List<Databases_Model> GetDatabases()
        {
            List<Databases_Model> all_databases = new List<Databases_Model>();
            
            foreach (BsonDocument db in client.ListDatabases().ToList())
            {
                all_databases.Add(BsonSerializer.Deserialize<Databases_Model>(db));
            }
            return all_databases;
        }

        public BsonDocument FindOneDocument(string collectionName, FilterDefinition<BsonDocument> filter)
        {
            database = client.GetDatabase("thegardengroup");
            var collection = database.GetCollection<BsonDocument>(collectionName);
            var firstDocument = collection.Find(filter).FirstOrDefault();

            return firstDocument;
        }
    }


}
