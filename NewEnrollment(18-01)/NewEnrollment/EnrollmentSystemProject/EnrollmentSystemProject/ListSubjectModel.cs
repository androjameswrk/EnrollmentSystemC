using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentSystemProject
{
    internal class ListSubjectModel
    {
        public class Subjects
        {
            [BsonId]
            public ObjectId Id { get; set; }

            [BsonElement("Program")]
            public string program { get; set; }

            [BsonElement("YearLevel")]
            public string yearlevel { get; set; }

            [BsonElement("Term")]
            public string term { get; set; }

            [BsonElement("CourseCode")]
            public string coursecode { get; set; }

            [BsonElement("Subject")]
            public string subject { get; set; }

            [BsonElement("Units")]
            public string units { get; set; }

            public Subjects(string program, string yearlevel, string term, string coursecode, string subject, string units)
            {
                this.program = program;
                this.yearlevel = yearlevel;
                this.term = term;
                this.coursecode = coursecode;
                this.subject = subject;
                this.units = units;
            }
        }
    }
}
