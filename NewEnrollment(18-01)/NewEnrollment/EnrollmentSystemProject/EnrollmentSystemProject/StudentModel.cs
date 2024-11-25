using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentSystemProject
{
    internal class StudentModel
    {
        public class Student
        {
            [BsonId]
            public ObjectId Id { get; set; }

            [BsonElement("StudNo")]
            public string studNo { get; set; }

            [BsonElement("EntryYear")]
            public string entryYear { get; set; }

            [BsonElement("Level")]
            public string level { get; set; }

            [BsonElement("Term")]
            public string term { get; set; }

            [BsonElement("Status")]
            public string status { get; set; }

            [BsonElement("Program")]
            public string program { get; set; }

            [BsonElement("Middlename")]
            public string middlename { get; set; }

            [BsonElement("Firstname")]
            public string firstname { get; set; }

            [BsonElement("Lastname")]
            public string lastname { get; set; }

            [BsonElement("Address")]
            public string address { get; set; }

            [BsonElement("Gender")]
            public string gender { get; set; }

            [BsonElement("Birthday")]
            public string birthday { get; set; }

            [BsonElement("Birthplace")]
            public string birthplace { get; set; }

            [BsonElement("Citizenship")]
            public string citizenship { get; set; }

            [BsonElement("Religion")]
            public string religion { get; set; }

            [BsonElement("ContactNo")]
            public string contactno { get; set; }

            [BsonElement("GoodMoral")]
            public string goodmoral { get; set; }

            [BsonElement("FormReq")]
            public string formreq { get; set; }

            [BsonElement("TransferCredentials")]
            public string transfercredentials { get; set; }

            [BsonElement("Transcripts")]
            public string transcripts { get; set; }

            public Student(string studNo, string entryYear, string level, string term, string status, string program, string middlename,
            string firstname, string lastname, string address, string gender, string birthday, string birthplace, string citizenship,
            string religion, string contactno, string goodmoral, string formreq, string transfercredentials, string transcripts)
            {
                this.studNo = studNo;
                this.entryYear = entryYear;
                this.level = level;
                this.term = term;
                this.status = status;
                this.program = program;
                this.middlename = middlename;
                this.firstname = firstname;
                this.lastname = lastname;
                this.address = address;
                this.gender = gender;
                this.birthday = birthday;
                this.birthplace = birthplace;
                this.citizenship = citizenship;
                this.religion = religion;
                this.contactno = contactno;
                this.goodmoral = goodmoral;
                this.formreq = formreq;
                this.transfercredentials = transfercredentials;
                this.transcripts = transcripts;
            }
        }
    }
}
