using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EnrollmentSystemProject.StudentModel;

namespace EnrollmentSystemProject
{
    class StudentController
    {
        private StudentData studentData;
        private StudentView studentView;
        public StudentController(EnrollStudentForm form)
        {
            studentData = new StudentData();
            studentView = new StudentView(form);
        }
        public StudentController(StudentMasterlistForm form2)
        {
            studentData = new StudentData();
            studentView = new StudentView(form2);
        }
        public StudentController(UpdateStudentForm form3)
        {
            studentData = new StudentData();
            studentView = new StudentView(form3);
        }
        public void registerStudent(Student student)
        {
            studentData.insertStudent(student);
        }

        public void updateStudent(Student student)
        {
            studentData.updateStudent(student);
            studentView.updateData(studentData.getStudentList());
            studentView.clearFields();
        }

        public void populateStudentFields(string chosenID)
        {
            var student = studentData.getStudentList().Find(s => s.studNo == chosenID);
            studentView.populateFields(student);
        }
        public void deleteStudent(string chosenID)
        {
            studentData.deleteStudent(chosenID);
            studentView.updateData(studentData.getStudentList());
        }
    }
}
