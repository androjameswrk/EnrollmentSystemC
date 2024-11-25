using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EnrollmentSystemProject.ListSubjectModel;

namespace EnrollmentSystemProject
{
    internal class ListSubjectData
    {
        private IMongoCollection<Subjects> collection;
        public ListSubjectData()
        {
            MongoDBConnection singleton = MongoDBConnection.GetInstance();
            IMongoDatabase db = singleton.GetMongoDatabase();
            collection = db.GetCollection<Subjects>("ListSubjectCollection");
        }
        public void insertSubject(Subjects subjects)
        {
            collection.InsertOne(subjects);
        }
        public void updateSubject(Subjects subjects)
        {
            var update = Builders<Subjects>.Update
                .Set("Term", subjects.term)
                .Set("YearLevel", subjects.yearlevel)
                .Set("Program", subjects.program)
                .Set("Subject", subjects.subject)
                .Set("Code", subjects.coursecode);
                collection.UpdateOne(s => s.Id == subjects.Id, update);
        }
        public void deleteSubject(string id)
        {
            var filter = Builders<Subjects>.Filter.Eq("_id", ObjectId.Parse(id));
            collection.DeleteOne(filter);
        }
        public List<Subjects> getSubjectList()
        {
            return collection.AsQueryable().ToList();
        }
    }
}
