using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EnrollmentSystemProject
{
    public partial class AdminLogIn : Form
    {
        private IMongoCollection<User> collection;
        private IMongoDatabase db;
        public AdminLogIn()
        {
            InitializeComponent();
        
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Enter username");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Enter password");
            }
            else if (txtUsername.Text == "MAK" && txtPassword.Text == "123")
            {
                this.Hide();
                LandingForm landingForm = new LandingForm();
                landingForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Credential.. Please see School Facilitor for username and password update..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
