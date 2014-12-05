﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using Adult.Domain.Mongo.Video;
using Adult.Server.Mongo;
using MongoDB.Driver.Linq;

namespace Server.Mongo
{
    class MongoService
    {
        private MongoServers _MongoServer { get { return new MongoServers(); } }
        private Int64 totalVideoCount { get; set; }
        public MongoService()
        {
            totalVideoCount = _MongoServer.videoCollection.Count();
        }
        public Video getVideo(String BsonId)
        {
            return _MongoServer.videoCollection.AsQueryable<Video>().Single(x => x._id.Equals(BsonId, StringComparison.Ordinal));
        }
      
        //public List<Video> getVideos(Int32 startIndex = 0, Int32 amount)
        //{
        //    if(amount - startIndex > totalVideoCount) 
        //        throw new IndexOutOfRangeException();
         
        //    return _MongoService.videoCollection
        //}
    }
}