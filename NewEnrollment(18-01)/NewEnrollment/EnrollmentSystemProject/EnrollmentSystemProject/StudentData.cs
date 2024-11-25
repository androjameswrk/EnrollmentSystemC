using MongoDB.Bson;
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
    internal class StudentData
    {
        private IMongoCollection<Student> collection;
        private IMongoCollection<Subjects> collection2;

        public StudentData()
        {
            //Mongo connectivity and retrieval of MongoDB/Collections
            MongoDBConnection singleton = MongoDBConnection.GetInstance();
            IMongoDatabase db = singleton.GetMongoDatabase();
            collection = db.GetCollection<Student>("StudentCollection");
            collection2 = db.GetCollection<Subjects>("ListSubjectCollection");
        }

        public void insertStudent(Student student)
        {
            collection.InsertOne(student);
        }
        public void updateStudent(Student student)
        {
            var update = Builders<Student>.Update
                .Set("studNo", student.studNo)
                .Set("entryYear", student.entryYear)
                .Set("level", student.level)
                .Set("term", student.term)
                .Set("status", student.status)
                .Set("program", student.program)
                .Set("middlename", student.middlename)
                .Set("firstname", student.firstname)
                .Set("lastname", student.lastname)
                .Set("address", student.address)
                .Set("gender", student.gender)
                .Set("birthday", student.birthday)
                .Set("birthplace", student.birthplace)
                .Set("citizenship", student.citizenship)
                .Set("religion", student.religion)
                .Set("contactno", student.contactno)
                .Set("goodmoral", student.goodmoral)
                .Set("formreq", student.formreq)
                .Set("transfercredentials", student.transfercredentials)
                .Set("transcripts", student.transcripts);

            collection.UpdateOne(s => s.studNo == student.studNo, update);
        }
        public void deleteStudent(string chosenID)
        {
            var filter = Builders<Student>.Filter.Eq("StudNo", chosenID);
            collection.DeleteOne(filter);
        }
        public List<Student> getStudentList()
        {
            return collection.AsQueryable().ToList();
        }
    }
}
