﻿using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using Model;
using MongoDB.Bson.Serialization;
using System;
using System.Linq;
using System.Net.Sockets;

namespace DAL
{
    public class BaseDao
    {
        private MongoClient _client;
        protected IMongoDatabase _database;
        public IMongoCollection<TicketModel> collection1;


        public BaseDao()
        {
            _client = new MongoClient("mongodb+srv://thegardengroup:ATPwszhhodqQ8Upi@cluster0.w8hjrzc.mongodb.net/");
            _database = _client.GetDatabase("thegardengroup");
            collection1 = _database.GetCollection<TicketModel>("tickets");
        }

        public void Insert(string collectionName, BsonDocument document)
        {
            var collection = _database.GetCollection<BsonDocument>(collectionName);
            collection.InsertOne(document);
        }

        public void InsertMany(string collectionName, List<BsonDocument> document)
        {
            var collection = _database.GetCollection<BsonDocument>(collectionName);
            collection.InsertMany(document);
        }

        public List<BsonDocument> Read(string collectionName, BsonDocument filter)
        {
            var collection = _database.GetCollection<BsonDocument>(collectionName);
            var result = collection.Find(filter).ToList();
            return result;
        }
        public void Delete(string collectionName, FilterDefinition<BsonDocument> filter)
        {
            var collection = _database.GetCollection<BsonDocument>(collectionName);
            collection.DeleteOne(filter);
        }

        public void DeleteMany<T>(string collectionName, FilterDefinition<T> filter)
        {
            var collection = _database.GetCollection<T>(collectionName);
            collection.DeleteMany(filter);
        }
    }
}
