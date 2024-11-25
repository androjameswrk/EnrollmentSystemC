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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EnrollmentSystemProject
{
    public partial class SearchbyNameForm : Form
    {
        public DataGridView SMstudentDGV;
        private IMongoCollection<Student> collection;
        public SearchbyNameForm()
        {
            InitializeComponent();
        }

        private void SearchbyNameForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            while (string.IsNullOrEmpty(searchBy.Text))
            {
                MessageBox.Show("Search cannot be empty!");
                return;
            }
            this.Hide();

            MongoDBConnection singleton = MongoDBConnection.GetInstance();
            IMongoDatabase db = singleton.GetMongoDatabase();
            collection = db.GetCollection<Student>("StudentCollection");

            var studentMasterlistForm = new StudentMasterlistForm();
            studentMasterlistForm.SearchByName(searchBy.Text);

            studentMasterlistForm.Show();

        }

        private void searchBy_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void searchBy_TextChanged(object sender, EventArgs e)
        {

        }
    }
}