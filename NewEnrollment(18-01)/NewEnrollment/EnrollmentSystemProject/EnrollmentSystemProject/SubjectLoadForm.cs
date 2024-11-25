using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EnrollmentSystemProject.EnrollStudentForm;
using static EnrollmentSystemProject.ListSubjectForm;
using static EnrollmentSystemProject.ListSubjectModel;
using static EnrollmentSystemProject.StudentModel;

namespace EnrollmentSystemProject
{

    public partial class SubjectLoadForm : Form
    {
        private readonly SubjectLoadData subjectLoadData;
        private readonly SubjectLoadController subjectLoadController;
        private readonly AssessmentController assessmentController;

        public SubjectLoadForm()
        {
            InitializeComponent();
            subjectLoadData = new SubjectLoadData();
            subjectLoadController = new SubjectLoadController();
            

        }

        private void SubjectLoad_Load(object sender, EventArgs e)
        {
            
        }

        private void cbStudNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //public void btnSearch_Click
           
        }

            private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnAddSubj_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //SET OTHER TEXT FIELDS ITS INFORMATION THAT MATCHES THE STUDENT
            var student = subjectLoadData.GetStudentByStudNo(txtStudName.Text);
            if (student != null)
            {
                txtStudNo.Text = student.studNo;
                txtLName.Text = student.lastname;
                txtMName.Text = student.middlename;
                txtFName.Text = student.firstname;
                txtAddress.Text = student.address;
                txtProgram.Text = student.program;
                txtYear.Text = student.level;
                txtTerm.Text = student.term;
                txtSY.Text = student.entryYear;
                txtStatus.Text = student.status;
                txtGender.Text = student.gender;
            }
            else
            {
                MessageBox.Show("Student not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //DISPLAY AVAILABLE SUBJECT FOR THE STUDENT BASE ON ITS PROGRAM, YEARLEVEL AND TERM.
            subjectLoadController.UpdateView(this);
        }

        private void SLsubjectDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //DISPLAY THE SELECTED SUBJECTS, TOTAL NUMBER OF SUBJECT, AND TOTAL NUMBER OF UNITS TO THE SUBJECTLOAD DGV 
            subjectLoadController.SelectSubjects(SLsubjectDGV, SubjectLoadDGV, txtNoOfSubjects, txtNoOfUnits);
        }
        private void SubjectLoadDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void txtNoOfUnits_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            // Copy the structure of the SubjectLoadDGV
            for (int i = 0; i < SubjectLoadDGV.Columns.Count; i++)
                dt.Columns.Add(SubjectLoadDGV.Columns[i].Name);
            // Copy the data of the SubjectLoadDGV
            for (int i = 0; i < SubjectLoadDGV.Rows.Count; i++)
                dt.Rows.Add(SubjectLoadDGV.Rows[i].Cells.OfType<DataGridViewCell>().Select(c => c.Value).ToArray());

            //assessmentController.Load(SubjectLoadDGV, txtStudName, txtStudNo, txtFName, txtLName, txtMName, 
            //    txtProgram, txtYear, txtTerm, txtSY, txtNoOfUnits, txtSection);

            string chosenStudent = txtStudName.Text;
            string cStudNo = txtStudNo.Text;
            string cFName = txtFName.Text;
            string cLName = txtLName.Text;
            string cMName = txtMName.Text;
            string cProgram = txtProgram.Text;
            string cYear = txtYear.Text;
            string cTerm = txtTerm.Text;
            string cSY = txtSY.Text;
            string cUnits = txtNoOfUnits.Text;
            string cSection = txtSection.Text;

            AssessmentForm assessmentForm = new AssessmentForm();
            assessmentForm.SubjectLoadDGVData = dt;
            assessmentForm.ChosenStudent = chosenStudent;
            assessmentForm.CStudNo = cStudNo;
            assessmentForm.CFName = cFName;
            assessmentForm.CLName = cLName;
            assessmentForm.CMName = cMName;
            assessmentForm.CProgram = cProgram;
            assessmentForm.CYear = cYear;
            assessmentForm.CTerm = cTerm;
            assessmentForm.CSY = cSY;
            assessmentForm.CSection = cSection;
            assessmentForm.CUnits = cUnits;

            assessmentForm.ShowDialog();
        }

        private void txtSection_TextChanged(object sender, EventArgs e)
        {

        }
    }
}