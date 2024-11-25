using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EnrollmentSystemProject.ListSubjectModel;

namespace EnrollmentSystemProject
{
    public class SubjectLoadModel
    {
        public DataTable SubjectLoadDGVData { get; set; }

        private readonly IMongoCollection<Subjects> collection;
        public SubjectLoadModel()
        {
            MongoDBConnection singleton = MongoDBConnection.GetInstance();
            IMongoDatabase db = singleton.GetMongoDatabase();
            collection = db.GetCollection<Subjects>("ListSubjectCollection");

            SubjectLoadDGVData = new DataTable();
            SubjectLoadDGVData.Columns.Add("_id");
            SubjectLoadDGVData.Columns.Add("Program");
            SubjectLoadDGVData.Columns.Add("YearLevel");
            SubjectLoadDGVData.Columns.Add("Term");
            SubjectLoadDGVData.Columns.Add("CourseCode");
            SubjectLoadDGVData.Columns.Add("Subject");
            SubjectLoadDGVData.Columns.Add("Units");
        }
        internal List<Subjects> GetSubjects(string program, string year, string term)
        {
            var filter = Builders<Subjects>.Filter.Eq("Program", program) &
                             Builders<Subjects>.Filter.Eq("YearLevel", year) &
                             Builders<Subjects>.Filter.Eq("Term", term);

            return collection.Find(filter).ToList();
        }
    }
}
