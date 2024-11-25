using MongoDB.Bson;
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
    public partial class UpdateStudentForm : Form
    {

        private StudentController studentController;

        public UpdateStudentForm(string studNo, string entryYear, string level, string term, string status, string program, string middlename, string lastname,
            string firstname, string gender, string birthday, string birthplace, string address, string citizenship, string religion, string contactNo)

        {
            InitializeComponent();
            studentController = new StudentController(this);
            txtStudNo.Text = studNo;
            cbEntryYear.Text = entryYear;
            cbLevel.Text = level;
            cbTerm1.Text = term;
            cbStatus.Text = status;
            cbProgram.Text = program;
            txtMiddlename.Text = middlename;
            txtLastname.Text = lastname;
            txtFirstname.Text = firstname;
            cbGender.Text = gender;
            txtBirthplace.Text = birthplace;
            txtAddress.Text = address;
            cbCitizenship.Text = citizenship;
            cbReligion.Text = religion;
            txtContactNo.Text = contactNo;

        }
        //PRE DEFINED STRING VARIABLES FOR REQUIREMENTS SECTION
        public string GoodMoral;
        public string FormReq;
        public string TransferCredentials;
        public string Transcripts;

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox && c.Name != "txtMiddlename")
                {
                    TextBox textBox = c as TextBox;
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        MessageBox.Show("Textbox cannot be empty!");
                        return;
                    }
                }
            }
            //foreach (Control c in this.Controls)
            //{
            //    if (c is ComboBox)
            //    {
            //        ComboBox comboBox = c as ComboBox;
            //        if (comboBox.SelectedItem == null)
            //        {
            //            MessageBox.Show("Please select a value from the combobox!");
            //            return;
            //        }
            //    }
            //}
            this.Hide();

            Student student = new Student(txtStudNo.Text, cbEntryYear.Text, cbLevel.Text, cbTerm1.Text, cbStatus.Text, cbProgram.Text,
           txtMiddlename.Text, txtFirstname.Text, txtLastname.Text, txtAddress.Text, cbGender.Text, birthdayPicker.Text,
           txtBirthplace.Text, cbCitizenship.Text, cbReligion.Text, txtContactNo.Text, GoodMoral, FormReq, TransferCredentials, Transcripts
           );
            student.studNo = txtStudNo.Text;
            studentController.updateStudent(student);

            StudentMasterlistForm studentMasterlistForm = new StudentMasterlistForm();
            studentMasterlistForm.ShowDialog();
        }

        private void UpdateStudentForm_Load(object sender, EventArgs e)
        {
            string[] ListOfLevel = new string[]
           {
                "1st year", "2nd year", "3rd year", "4th year",
           };
            for (int i = 0; i < 4; i++)
            {
                cbLevel.Items.Add(ListOfLevel[i].ToString());
            }
            //COMBO BOX FOR TERM
            string[] ListOfTerm = new string[]
            {
                "1st term","2nd term",
            };
            for (int i = 0; i < 2; i++)
            {
                cbTerm1.Items.Add(ListOfTerm[i].ToString());
            }
            //COMBO BOX FOR STATUS
            string[] ListOfStatus = new string[]
             {
                "Single", "Married",  "Widowed",  "Divorced",  "Separated",
             };
            for (int i = 0; i < 5; i++)
            {
                cbStatus.Items.Add(ListOfStatus[i].ToString());
            }
            //COMBO BOX FOR PROGRAM
            string[] ListOfProgram = new string[]
            {
                "BS in Information Technology (BSIT)","BS in Computer Science (BSCS)","BS in Information Systems (BSIS)","2-yr. Information Technology (IT)","2-yr. Associate in Computer Technology (ACT)",
                "BS in Business Administration (BSBA)","BS in Accountancy (BSA)", "BS in Accounting Information Systems (BSAIS)","BS in Management Accounting (BSMA)","BS in Retail Technology and Consumer Science (BSRTCS)", "2-yr. Associate in Retail Technology (ART)",
                "BS in Hospitality Management (BSHM)", "BS in Culinary Management (BSCM)","3-yr. Hotel and Restaurant Administration (HRA)","2-yr. Hospitality and Restaurant Services (HRS)", "2-yr Professional Culinary Arts","BS in Tourism Management (BSTM)", "2-yr. Tourism and Events Management (TEM)",
                "BS in Computer Engineering (BSCpE)", "Bachelor of Multimedia Arts (BMMA)", "BA in Communication (BACOMM)","Bachelor of Science in Marine Transportation (BSMT)", "Bachelor of Science in Marine Engineering (BSMarE)", "Bachelor of Science in Naval Architecture and Marine Engineering (BSNAME)"
             };
            for (int i = 0; i < 24; i++)
            {
                cbProgram.Items.Add(ListOfProgram[i].ToString());
            }
            //COMBO BOX FOR GENDER
            string[] ListOfGender = new string[]
           {
                "Male", "Female",

           };
            for (int i = 0; i < 2; i++)
            {
                cbGender.Items.Add(ListOfGender[i].ToString());
            }
            //COMBO BOX FOR ENTRY YEAR
            string[] ListOfEntryYear = new string[]
           {
                "2022-2023", "2023-2024", "2024-2025", "2025-2026", "2026-2027", "2027,2028"
           };
            for (int i = 0; i < 6; i++)
            {
                cbEntryYear.Items.Add(ListOfEntryYear[i].ToString());
            }
            //COMBO BOX FOR CITIZENSHIP
            string[] ListOfCitizenship = new string[]
          {
                 "Filipino", "American", "Chinese", "Korean", "Japanese", "Taiwanese", "Australian", "Canadian", "British", "Singaporean",
              "Malaysian", "Indian", "German", "French", "Spanish", "Russian"
          };
            for (int i = 0; i < 6; i++)
            {
                cbCitizenship.Items.Add(ListOfCitizenship[i].ToString());
            }
            //COMBO BOX FOR RELIGION
            string[] ListOfReligion = new string[]
          {
                "Roman Catholicism", "Iglesia ni Cristo", "Evangelical Christianity", "Seventh-day Adventism", "Aglipayan",
                "Bible Baptist Church", "United Church of Christ in the Philippines", "Others"
          };
            for (int i = 0; i < 8; i++)
            {
                cbReligion.Items.Add(ListOfReligion[i].ToString());
            }
        }
    }
}