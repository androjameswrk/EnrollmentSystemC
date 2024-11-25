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
    internal class AssessmentModel
    {
        public DataTable SubjectLoadDGVData { get; set; }
        public string ChosenStudent { get; set; }
        public string CStudNo { get; set; }
        public string CFName { get; set; }
        public string CLName { get; set; }
        public string CMName { get; set; }
        public string CProgram { get; set; }
        public string CYear { get; set; }
        public string CTerm { get; set; }
        public string CSY { get; set; }
        public string CUnits { get; set; }
        public string CSection { get; set; }
        
    }
}
