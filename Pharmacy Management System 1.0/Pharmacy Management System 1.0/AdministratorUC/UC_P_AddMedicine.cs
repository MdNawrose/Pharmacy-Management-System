using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System_1._0.AdministratorUC
{
    public partial class UC_P_AddMedicine : UserControl
    {

        function fn = new function();
        String query;


        public UC_P_AddMedicine()
        {
            InitializeComponent();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void UC_P_AddMedicine_Load(object sender, EventArgs e)
        {

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel9_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel11_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel10_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMedicineID.Text != "" && txtMedicineName.Text != "" && txtMedicineNumber.Text != "" && txtQuantity.Text != "" && txtPricePerUnit.Text != "")
            {
                String mid = txtMedicineID.Text;
                String mname = txtMedicineName.Text;
                String mnumber = txtMedicineNumber.Text;
                String mdate = txtManufacturingDate.Text;
                String edate = txtExpeireDate.Text;
                Int64 quantity = Int64.Parse(txtQuantity.Text);
                Int64 perunit = Int64.Parse(txtPricePerUnit.Text);

                query = "insert into medic(mid,mname,mnumber,mdate,edate,quantity,perunit) values ('" + mid + "','" + mname + "','" + mnumber + "','" + mdate + "','" + edate + "'," + quantity + "," + perunit + ")";
                fn.setData(query, "Medicine Added to Database.");
            }
            else
            {
                MessageBox.Show("Enter All Data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            txtMedicineID.Clear();
            txtMedicineName.Clear();
            txtMedicineNumber.Clear();
            txtManufacturingDate.ResetText();
            txtExpeireDate.ResetText();
            txtQuantity.Clear();
            txtPricePerUnit.Clear();
        }

        private void txtExpeireDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void UC_P_AddMedicine_Load_1(object sender, EventArgs e)
        {

        }
    }
}
