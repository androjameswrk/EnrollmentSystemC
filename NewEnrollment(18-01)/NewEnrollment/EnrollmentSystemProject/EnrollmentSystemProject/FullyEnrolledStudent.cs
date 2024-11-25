using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentSystemProject
{
    internal class FullyEnrolledStudent
    {
        public DataTable SubjectLoadDGVData { get; internal set; }

        public class FullyEnrolledStudents
        {
            [BsonId]
            public ObjectId Id { get; set; }

            [BsonElement("SubjectLoadDGVData")]
            public DataTable SubjectLoadDGVData { get; set; }

            [BsonElement("Student")]
            public string ChosenStudent { get; set; }

            [BsonElement("StudNo")]
            public string CStudNo { get; set; }

            [BsonElement("CFName")]
            public string CFName { get; set; }

            [BsonElement("CLName")]
            public string CLName { get; set; }

            [BsonElement("CMName")]
            public string CMName { get; set; }

            [BsonElement("CProgram")]
            public string CProgram { get; set; }

            [BsonElement("CTerm")]
            public string CTerm { get; set; }

            [BsonElement("CYear")]
            public string CYear { get; set; }

            [BsonElement("CSY")]
            public string CSY { get; set; }

            [BsonElement("CSection")]
            public string CSection { get; set; }

            [BsonElement("CUnits")]
            public string CUnits{ get; set; }


            //public ObjectId Id { get; set; }
            //public DataTable SubjectLoadDGVData { get; set; }

            //public string ChosenStudent { get; set; }
            //public string CStudNo { get; set; }
            //public string CFName { get; set; }
            //public string CLName { get; set; }
            //public string CMName { get; set; }
            //public string CProgram { get; set; }
            //public string CTerm { get; set; }
            //public string CYear { get; set; }
            //public string CSY { get; set; }
            //public string CSection { get; set; }
            //public string CUnits { get; set; }

            public FullyEnrolledStudents(DataTable subjectLoadDGVData, string chosenStudent, string cStudNo, string cFName, string cLName, 
                string cMName, string cProgram, string cTerm, string cYear, string cSY, string cSection, string cUnits)
            {
                SubjectLoadDGVData = subjectLoadDGVData;
                ChosenStudent = chosenStudent;
                CStudNo = cStudNo;
                CFName = cFName;
                CLName = cLName;
                CMName = cMName;
                CProgram = cProgram;
                CTerm = cTerm;
                CYear = cYear;
                CSY = cSY;
                CSection = cSection;
                CUnits = cUnits;
            }
        }
    }
}
