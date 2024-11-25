using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentSystemProject
{
    internal class PricingModel
    {
        public class Pricing
        {
            [BsonId]
            public ObjectId Id { get; set; }

            [BsonElement("SY")]
            public string sy { get; set; }

            [BsonElement("Term")]
            public string term { get; set; }

            [BsonElement("TuitionFee")]
            public string tuitionFee { get; set; }

            [BsonElement("TotalOSFPrice")]
            public decimal totalOSF { get; set; }

            [BsonElement("TotalMFPrice")]
            public decimal totalMF { get; set; }

            public Pricing(string sy, string term, string tuitionFee, decimal totalOSF, decimal totalMF)
            {
                this.sy = sy;
                this.term = term;
                this.tuitionFee = tuitionFee;
                this.totalOSF= totalOSF;
                this.totalMF = totalMF;
            }
        }
    }
}
