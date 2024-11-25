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
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;
using TextBox = System.Windows.Forms.TextBox;

namespace EnrollmentSystemProject
{
    public partial class PricingForm : Form
    {
        private PricingController pricingController;
        private IMongoCollection<Pricing> collection;
        private decimal osPrice;

        public PricingForm()
        {
            InitializeComponent();
            pricingController = new PricingController(this);
        }

        private void PricingForm_Load(object sender, EventArgs e)
        {
            string[] ListOfEntryYear = new string[]
          {
                "2022-2023", "2023-2024", "2024-2025", "2025-2026", "2026-2027", "2027,2028"
          };
            for (int i = 0; i < 6; i++)
            {
                cbSY.Items.Add(ListOfEntryYear[i].ToString());
            }
            string[] ListOfTerm = new string[]
           {
                "1st term","2nd term",
           };
            for (int i = 0; i < 2; i++)
            {
                cbTerm.Items.Add(ListOfTerm[i].ToString());
            }
        }

        private void btnAddOSFee_Click(object sender, EventArgs e)
        {
            string osFee = txtOSFee.Text;
            string osPrice = txtOSFPrice.Text;
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (c.Name != "txtTFee" && c.Name != "txtMFee" && c.Name != "txtMPrice")
                    {
                        if (string.IsNullOrWhiteSpace(textBox.Text))
                        {
                            MessageBox.Show("Textbox cannot be empty!");
                            return;
                        }
                    }
                }
            }

            // Add the values as a new row to the DataGridView
            int newRowIndex = OSFDGV.Rows.Add();
            OSFDGV.Rows[newRowIndex].Cells["Fee"].Value = osFee;
            OSFDGV.Rows[newRowIndex].Cells["Price"].Value = osPrice;
        }

        private void btnAddMFee_Click(object sender, EventArgs e)
        {
            string mFee = txtMFee.Text;
            string mPrice = txtMPrice.Text;
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (c.Name != "txtTFee" && c.Name != "txtOSFee" && c.Name != "txtOSFPrice")
                    {
                        if (string.IsNullOrWhiteSpace(textBox.Text))
                        {
                            MessageBox.Show("Textbox cannot be empty!");
                            return;
                        }
                    }
                }
            }

            // Add the values as a new row to the DataGridView
            int newRowIndex = MFDGV.Rows.Add();
            MFDGV.Rows[newRowIndex].Cells["Fees"].Value = mFee;
            MFDGV.Rows[newRowIndex].Cells["Prices"].Value = mPrice;

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            while (string.IsNullOrEmpty(txtTFee.Text))
            {
                MessageBox.Show("Textbox cannot be empty!");
                return;
            }
            if (OSFDGV.Rows.Count == 1)
            {
                MessageBox.Show("Other School Fees cannot be empty!");
                return;
            }
            if (MFDGV.Rows.Count == 1)
            {
                MessageBox.Show("Miscellaneous Fees cannot be empty!");
                return;
            }
            foreach (Control c in this.Controls)
            {
                if (c is ComboBox)
                {
                    ComboBox comboBox = c as ComboBox;
                    if (comboBox.SelectedItem == null)
                    {
                        MessageBox.Show("Please select an item from the combobox!");
                        return;
                    }
                }
            }
            decimal totalOSF = 0;
            foreach (DataGridViewRow row in OSFDGV.Rows)
            {
                decimal osPrice = Convert.ToDecimal(row.Cells["Price"].Value);
                totalOSF += osPrice;
            }

            decimal totalMF = 0;
            foreach (DataGridViewRow row in MFDGV.Rows)
            {
                decimal mPrice = Convert.ToDecimal(row.Cells["Prices"].Value);
                totalMF += mPrice;
            }

            Pricing pricing = new Pricing(cbSY.Text, cbTerm.Text, txtTFee.Text, totalOSF, totalMF);
            pricingController.registerPrice(pricing);
            MessageBox.Show("Pricing has been added successfully!");
            //  this.Close();
            foreach (Control c in this.Controls)
            {
                if (c is DataGridView)
                {
                    DataGridView dgv = (DataGridView)c;
                    dgv.DataSource = null;
                    dgv.Rows.Clear();
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.SelectedIndex = -1;
                    cb.SelectedItem = null;
                    cb.Text = "";
                }
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Text = "";
                }
            }

        }

        private void OSFDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtOSFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtOSFPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtMPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}