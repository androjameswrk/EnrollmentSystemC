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
using static EnrollmentSystemProject.ListSubjectModel;

namespace EnrollmentSystemProject
{
    public partial class ListSubjectForm : Form
    {
        private ListSubjectController listSubjectController;

        public ListSubjectForm()
        {
            InitializeComponent();
            listSubjectController = new ListSubjectController(this);
        }

        private void ListSubjectForm_Load(object sender, EventArgs e)
        {

            string[] ListOfProgram = new string[]
           {
                "BS in Information Technology (BSIT)", "BS in Computer Science (BSCS)", "BS in Information Systems (BSIS)", "BS in Business Administration (BSBA)",
                "BS in Accountancy (BSA)", "BS in Accounting Information Systems (BSAIS)", "BS in Management Accounting (BSMA)", "BS in Hospitality Management (BSHM)", 
                "BS in Culinary Management (BSCM)",  "3-yr. Hotel and Restaurant Administration (HRA)", "2-yr. Hospitality and Restaurant Services (HRS)",
                "2-yr Professional Culinary Arts",
      };
            for (int i = 0; i < 12; i++)
            {
                cbProgram.Items.Add(ListOfProgram[i].ToString());
            }

            //combo box for yearlevel
            string[] ListOfLevel = new string[]
            {
                "1st year", "2nd year", "3rd year",
                "4th year",
            };
            for (int i = 0; i < 4; i++)
            {
                cbYearLevel.Items.Add(ListOfLevel[i].ToString());
            }

            string[] ListOfTerm = new string[]
           {
                "1st term",
                "2nd term",
           };
            for (int i = 0; i < 2; i++)
            {
                cbTerm.Items.Add(ListOfTerm[i].ToString());
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (c.Name != "txtID")
                    {
                        if (string.IsNullOrWhiteSpace(textBox.Text))
                        {
                            MessageBox.Show("Textbox cannot be empty!");
                            return;
                        }
                    }
                }
            }

            //registerbtn
            Subjects subjects = new Subjects(cbProgram.Text, cbYearLevel.Text, cbTerm.Text, txtCode.Text, txtSubject.Text, txtUnits.Text);
            listSubjectController.registerSubject(subjects);
        }
        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            listSubjectController.deleteSubject(id);
        }
        private void SubjectDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = SubjectDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbProgram.Text = SubjectDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbYearLevel.Text = SubjectDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbTerm.Text = SubjectDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtCode.Text = SubjectDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtSubject.Text = SubjectDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void SubjectDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtUnits_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
