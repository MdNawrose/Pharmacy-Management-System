using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System_1._0.PharmacistUC
{
    public partial class UC_P_ViewMedcien : UserControl
    {

        function fn = new function();
        String query;
        public UC_P_ViewMedcien()
        {
            InitializeComponent();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void UC_P_ViewMedcien_Load(object sender, EventArgs e)
        {
            query = "select * from medic";
            setDataGridView(query);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from medic where mname like '" + txtSearch.Text + "%'";
            setDataGridView(query);
        }

        private void setDataGridView(String query)
        {
            DataSet ds = fn.getData(query);
            gunaDataGridView3.DataSource = ds.Tables[0];
        }


        String medicineId;
        private void gunaDataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                medicineId = gunaDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }

            catch { }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Delete Confirmation !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "Delete from medic where mid = '" + medicineId + "'";
                fn.setData(query, "Medicine Record Deleteed");
                UC_P_ViewMedcien_Load(this,null);
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_P_ViewMedcien_Load(this, null);
        }
    }
}
