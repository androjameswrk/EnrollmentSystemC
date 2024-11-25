using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentSystemProject
{
    public class MongoDBConnection
    {
        private static MongoDBConnection single_instance = null;
        private IMongoClient mongoClient;
        private IMongoDatabase mongoDatabase;

        private MongoDBConnection()
        {
            mongoClient = new MongoClient("mongodb://localhost:27017/");
            mongoDatabase = mongoClient.GetDatabase("EnrollmentSystemDB");
        }
        public static MongoDBConnection GetInstance()
        {
            {
                if (single_instance == null)
                    single_instance = new MongoDBConnection();
                return single_instance;

            }
        }
        public IMongoDatabase GetMongoDatabase()
        {
            return mongoDatabase;
        }
    }
}