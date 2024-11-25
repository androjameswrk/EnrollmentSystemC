using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EnrollmentSystemProject.ListSubjectModel;
using static EnrollmentSystemProject.StudentModel;

namespace EnrollmentSystemProject
{
    internal class SubjectLoadData
    {
        private IMongoCollection<Student> collection;

        public SubjectLoadData()
        {
            MongoDBConnection singleton = MongoDBConnection.GetInstance();
            IMongoDatabase db = singleton.GetMongoDatabase();
            collection = db.GetCollection<Student>("StudentCollection");
        }
        public Student GetStudentByStudNo(string studName)
        {
            var filter = Builders<Student>.Filter.Eq(s => s.firstname, studName);
            return collection.Find(filter).FirstOrDefault();
        }
    }
}
