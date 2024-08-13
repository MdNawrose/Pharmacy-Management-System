using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System_1._0.PharmacistUC
{
    public partial class UC_P_UpdateMedicine : UserControl
    {

        function fn = new function();
        String query;

        public UC_P_UpdateMedicine()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtMediID.Text != "") 
            {
                query = "select * from medic where mid = '" + txtMediID.Text + "'";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {

                }
                else
                {
                    MessageBox.Show("No Medicine with ID : " + txtMediID.Text + "exitst", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else
            {
                clearAll();
            }
        }
        private void clearAll()
        {

        }
    }
}
