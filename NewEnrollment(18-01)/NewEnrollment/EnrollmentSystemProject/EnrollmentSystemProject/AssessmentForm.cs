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
using static EnrollmentSystemProject.PricingModel;

namespace EnrollmentSystemProject
{
    public partial class AssessmentForm : Form
    {
        private IMongoCollection<Pricing> collection;
        private readonly PricingData pricingData;
        private readonly AssessmentController assessmentController;

        public AssessmentForm()
        {
            InitializeComponent();
            assessmentController = new AssessmentController(this);
            pricingData = new PricingData();
        }


        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txtStudNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void AssessmentForm_Load(object sender, EventArgs e)
        {
            AFsubjectDGV.DataSource = SubjectLoadDGVData;
            txtStudNo.Text = CStudNo;
            txtFName.Text = CFName;
            txtLName.Text = CLName;
            txtMName.Text = CMName;
            txtProgram.Text = CProgram;
            txtTerm.Text = CTerm;
            txtYear.Text = CYear;
            txtSY.Text = CSY;
            txtSection.Text = CSection;



            int Units = int.Parse(CUnits);
            var pricing = pricingData.GetPricingBySy(txtSY.Text);

            string sy = pricing.sy;
            string term = pricing.term;
            string tuitionFee = pricing.tuitionFee;
            decimal OSF = pricing.totalOSF;
            decimal MFEe = pricing.totalMF;

            //Computation for TuitionFee
            Double TFee = Convert.ToDouble(tuitionFee);
            double TTuition = TFee * Units;
            string Tuition = Math.Round(TTuition, 2, MidpointRounding.ToEven).ToString();
            lblTFee.Text = Tuition;

            //OtherSchool Fees
            double osF = Decimal.ToDouble(OSF);
            lblOSFee.Text = Math.Round(osF, 2, MidpointRounding.ToEven).ToString();

            //MiscFee
            double MFE = Decimal.ToDouble(MFEe);
            lblMFee.Text = Math.Round(MFE, 2, MidpointRounding.ToEven).ToString();

            //Total Assessment
            double TotalAssessment = TTuition + osF + MFE;
            lblTotalA.Text = Math.Round(TotalAssessment, 2, MidpointRounding.ToEven).ToString();

            //Upon Enrollment
            double UponE = TotalAssessment / 2;
            lblUEPrice.Text = Math.Round(UponE, 2, MidpointRounding.ToEven).ToString();

            //MonthlyPayment
            double MonthlyPayment = UponE / 4;
            lblPrice1.Text = Math.Round(MonthlyPayment, 2, MidpointRounding.ToEven).ToString();
            lblPrice2.Text = Math.Round(MonthlyPayment, 2, MidpointRounding.ToEven).ToString();
            lblPrice3.Text = Math.Round(MonthlyPayment, 2, MidpointRounding.ToEven).ToString();
            lblPrice4.Text = Math.Round(MonthlyPayment, 2, MidpointRounding.ToEven).ToString();

            lblTotalOB.Text = TotalAssessment.ToString();

        }
        public DataTable SubjectLoadDGVData { get; set; }
        public string ChosenStudent { get; set; }
        public string CStudNo { get; set; }
        public string CFName { get; set; }
        public string CLName { get; set; }
        public string CMName { get; set; }
        public string CProgram { get; set; }
        public string CTerm { get; set; }
        public string CYear { get; set; }
        public string CSY { get; set; }
        public string CSection { get; set; }
        public string CUnits { get; set; }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            string message = "Do you wish to confirm this enrollment?";
            string caption = "Confirmation";
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Enrolled Successfully");
                this.Close();
            }

            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("EnrollmentSystemDB");
            var collection = database.GetCollection<FullyEnrolledStudent>("FullyEnrolledStudent");

            FullyEnrolledStudent fullyEnrolledStudent = new FullyEnrolledStudent();
            collection.InsertOne(fullyEnrolledStudent);
        }
    }
}
