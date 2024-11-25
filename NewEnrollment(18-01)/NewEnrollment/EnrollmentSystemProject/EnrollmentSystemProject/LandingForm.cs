using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrollmentSystemProject
{
    public partial class LandingForm : Form
    {
        public LandingForm()
        {
            InitializeComponent();
        }

        private void txtStudent_Click(object sender, EventArgs e)
        {
           
        }

        private void txtEnroll_Click(object sender, EventArgs e)
        {
            
            StudentMasterlistForm studentMasterlistForm = new StudentMasterlistForm();
            studentMasterlistForm.ShowDialog();
        }

        private void LandingForm_Load(object sender, EventArgs e)
        {

        }

        private void txtListSubjects_Click(object sender, EventArgs e)
        {
            ListSubjectForm listSubjectForm = new ListSubjectForm();
            listSubjectForm.ShowDialog();
        }

        private void txtLoadSubjects_Click(object sender, EventArgs e)
        {
            SubjectLoadForm subjectLoadForm = new SubjectLoadForm();
            subjectLoadForm.ShowDialog();
        }

        private void btnPricing_Click(object sender, EventArgs e)
        {
            PricingForm pricingForm = new PricingForm();
            pricingForm.ShowDialog();
        }
    }
}
