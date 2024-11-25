using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EnrollmentSystemProject.PricingModel;
using static EnrollmentSystemProject.StudentModel;

namespace EnrollmentSystemProject
{
    internal class PricingData
    {
        private IMongoCollection<Pricing> collection;

        public PricingData()
        {
            //Mongo connectivity and retrieval of MongoDB/Collections
            MongoDBConnection singleton = MongoDBConnection.GetInstance();
            IMongoDatabase db = singleton.GetMongoDatabase();
            collection = db.GetCollection<Pricing>("PricingCollection");

        }
        public void insertPrice(Pricing pricing)
        {
            collection.InsertOne(pricing);
        }
        public Pricing GetPricingBySy(string sy)
        {
            var filter = Builders<Pricing>.Filter.Eq(s => s.sy, sy);
            return collection.Find(filter).FirstOrDefault();
        }
    }
}
