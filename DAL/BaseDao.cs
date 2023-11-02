using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using Model;
using MongoDB.Bson.Serialization;
using System;
using System.Linq;

namespace DAL
{
    public class BaseDao
    {
        private MongoClient _client;
        private IMongoDatabase _database;

        public BaseDao()
        {
            _client = new MongoClient("mongodb+srv://thegardengroup:ATPwszhhodqQ8Upi@cluster0.w8hjrzc.mongodb.net/");
            _database = _client.GetDatabase("thegardengroup");
        }

        public void Insert(string collectionName, BsonDocument document)
        {
            var collection = _database.GetCollection<BsonDocument>(collectionName);
            collection.InsertOne(document);
        }

        public List<BsonDocument> Read(string collectionName, BsonDocument filter)
        {
            var collection = _database.GetCollection<BsonDocument>(collectionName);
            var result = collection.Find(filter).ToList();
            return result;
        }

        public void Update(string collectionName, BsonDocument filter, BsonDocument document)
        {
            var collection = _database.GetCollection<BsonDocument>(collectionName);
            collection.UpdateOne(filter, document);
        }
    }
}
