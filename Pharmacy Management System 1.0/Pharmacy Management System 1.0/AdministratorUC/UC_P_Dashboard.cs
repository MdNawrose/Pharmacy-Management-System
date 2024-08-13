using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System_1._0.AdministratorUC
{
    public partial class UC_P_Dashboard : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        Int64 count;


        public UC_P_Dashboard()
        {
            InitializeComponent();
        }

        private void UC_P_Dashboard_Load(object sender, EventArgs e)
        {
            loadChart();
        }
        
        public void loadChart()

        {
            
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {

        }
    }
}
