using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EnrollmentSystemProject.StudentModel;

namespace EnrollmentSystemProject
{
    internal class StudentView
    {
        private EnrollStudentForm form;
        private StudentMasterlistForm form2;
        private UpdateStudentForm form3;

        public StudentView(EnrollStudentForm form)
        {
            this.form = form;
        }

        public StudentView(StudentMasterlistForm form2)
        {
            this.form2 = form2;
        }
        public StudentView(UpdateStudentForm form3)
        {
            this.form3 = form3;
        }

        public void updateData(List<Student> studlist)
        {
            StudentMasterlistForm form2 = new StudentMasterlistForm();
            StudentView view = new StudentView(form2);
            form2.SMstudentDGV.DataSource = studlist;
            form2.SMstudentDGV.Refresh();
        }

        public void clearFields()
        {
            form3.txtStudNo.Text = "";
            form3.cbEntryYear.Text = "";
            form3.cbLevel.Text = "";
            form3.cbTerm1.Text = "";
            form3.cbStatus.Text = "";
            form3.cbProgram.Text = "";
            form3.txtMiddlename.Text = "";
            form3.txtFirstname.Text = "";
            form3.txtLastname.Text = "";
            form3.txtAddress.Text = "";
            form3.cbGender.Text = "";
            form3.birthdayPicker.Text = "";
            form3.txtBirthplace.Text = "";
            form3.cbCitizenship.Text = "";
            form3.cbReligion.Text = "";
            form3.txtContactNo.Text = "";
            form3.GoodMoral = "";
            form3.FormReq = "";
            form3.TransferCredentials = "";
            form3.Transcripts = "";
        }

        public void populateFields(Student student)
        {
            form3.txtStudNo.Text = student.studNo;
            form3.cbEntryYear.Text = student.entryYear;
            form3.cbLevel.Text = student.level;
            form3.cbTerm1.Text = student.term;
            form3.cbStatus.Text = student.status;
            form3.cbProgram.Text = student.program;
            form3.txtMiddlename.Text = student.middlename;
            form3.txtFirstname.Text = student.firstname;
            form3.txtLastname.Text = student.lastname;
            form3.txtAddress.Text = student.address;
            form3.cbGender.Text = student.gender;
            form3.birthdayPicker.Text = student.birthday;
            form3.txtBirthplace.Text = student.birthplace;
            form3.cbCitizenship.Text = student.citizenship;
            form3.cbReligion.Text = student.religion;
            form3.txtContactNo.Text = student.contactno;
            form3.GoodMoral = student.goodmoral;
            form3.FormReq = student.formreq;
            form3.TransferCredentials = student.transfercredentials;
            form3.Transcripts = student.transcripts;
        }
    }
}
