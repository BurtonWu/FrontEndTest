﻿using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adult.Domain.Mongo.Video;



namespace Adult.Server.Mongo
{
    public class MongoServers
    {
        private MongoDatabase MDB { get; set; }
        public MongoCollection videoCollection { get; set; }
        public MongoCollection tagCollection { get; set; }
        public MongoCollection counterCollection { get; set; }
        public MongoServers()
        {
            /*If you wanted to set the server address
             * MongoClientSettings settings = new MongoClientSettings();
             * settings.Server = new MongoServerAddress("localhost, 27017);
             * MongoClient client = new MongoClient(settings);
             */
            this.MDB = new MongoClient().GetServer().GetDatabase("videoDB");
            this.videoCollection = MDB.GetCollection<Video>("allVideos");
            this.tagCollection = MDB.GetCollection<Tags>("tags");
            this.counterCollection = MDB.GetCollection("counter");
        }
    
        
    }
}
