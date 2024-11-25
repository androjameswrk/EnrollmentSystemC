using MongoDB.Bson;
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
using static EnrollmentSystemProject.StudentModel;

namespace EnrollmentSystemProject
{
    public partial class StudentMasterlistForm : Form
    {
        private IMongoCollection<Student> collection;
        private StudentController studentController;
        public BsonDocument SelectedStudent { get; set; }
        public DataGridView StudentDGV
        {
            get
            {
                return SMstudentDGV;
            }
        }
        public StudentMasterlistForm()
        {
            InitializeComponent();
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("EnrollmentSystemDB");
            collection = database.GetCollection<Student>("StudentCollection");
            studentController = new StudentController(this);
        }

        private void StudentMasterlistForm_Load(object sender, EventArgs e)
        {
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            int selectedRow = SMstudentDGV.CurrentRow.Index;
            // Get the data from the selected row
            string studNo = SMstudentDGV[1, selectedRow].Value.ToString();
            string entryYear = SMstudentDGV[2, selectedRow].Value.ToString();
            string level = SMstudentDGV[3, selectedRow].Value.ToString();
            string term = SMstudentDGV[4, selectedRow].Value.ToString();
            string status = SMstudentDGV[5, selectedRow].Value.ToString();
            string program = SMstudentDGV[6, selectedRow].Value.ToString();
            string middlename = SMstudentDGV[7, selectedRow].Value.ToString();
            string firstname = SMstudentDGV[8, selectedRow].Value.ToString();
            string lastname = SMstudentDGV[9, selectedRow].Value.ToString();
            string address = SMstudentDGV[10, selectedRow].Value.ToString();
            string gender = SMstudentDGV[11, selectedRow].Value.ToString();
            string birthday = SMstudentDGV[12, selectedRow].Value.ToString();
            string birthplace = SMstudentDGV[13, selectedRow].Value.ToString();
            string citizenship = SMstudentDGV[14, selectedRow].Value.ToString();
            string religion = SMstudentDGV[15, selectedRow].Value.ToString();
            string contactNo = SMstudentDGV[16, selectedRow].Value.ToString();

            UpdateStudentForm updateForm = new UpdateStudentForm(studNo, entryYear, level, term, status, program, middlename,
            lastname, firstname, gender, birthday, birthplace, address, citizenship, religion, contactNo);

            updateForm.Show();
        }

        private void SMstudentDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var studentNo = SMstudentDGV.Rows[e.RowIndex].Cells["StudNo"].Value.ToString();
                txtID.Text = studentNo;

                var filter = Builders<Student>.Filter.Eq("StudentNo", studentNo);
                var selectedStudent = collection.Find(filter).FirstOrDefault();

            }
            //if (e.RowIndex >= 0)
            //{
            //    var studentNo = SMstudentDGV.Rows[e.RowIndex].Cells["StudentNo"].Value.ToString();

            //    var client = new MongoClient("mongodb://localhost:27017");
            //    var database = client.GetDatabase("studentDB");
            //    var collection = database.GetCollection<BsonDocument>("students");

            //    var filter = Builders<BsonDocument>.Filter.Eq("StudentNo", studentNo);
            //    SelectedStudent = collection.Find(filter).FirstOrDefault();
            //}

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchbyNameForm searchbyNameForm = new SearchbyNameForm();
            searchbyNameForm.ShowDialog();

        }
        public void SearchByName(string name)
        {
            var filter = Builders<Student>.Filter.Eq("Firstname", name);
            var searchByStudent = collection.Find(filter).ToList();
            SMstudentDGV.DataSource = searchByStudent;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnrollStudentForm enrollStudentForm = new EnrollStudentForm();
            enrollStudentForm.ShowDialog();

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            StudentData studentData = new StudentData();
            var studentList = studentData.getStudentList();
            SMstudentDGV.DataSource = studentList;
        }

        private void SMstudentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            StudentData studentData = new StudentData();
            string chosenID = txtID.Text;
            studentController.deleteStudent(chosenID);
            var studentList = studentData.getStudentList();
            SMstudentDGV.Refresh();
            SMstudentDGV.DataSource = studentList;
        }
    }
}
