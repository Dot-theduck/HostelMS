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
using System.Windows.Forms.DataVisualization.Charting;

namespace HostelMS
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            CountAllRooms();
            CountAllTenants();
            SumCost();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DOTTHEDUCK;Initial Catalog=HostelDb;Integrated Security=True;");
        public void CountAllRooms()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from RoomTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            RoomsLbl.Text = dt.Rows[0][0].ToString()+ " Rooms";
            Con.Close();
        }
        public void CountAllTenants()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from TenantTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            TenantsLbl.Text = dt.Rows[0][0].ToString() + " Tenants";
            Con.Close();
        }
        public void SumCost()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select sum(AmountPaid) from BookTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            FinancesLbl.Text = " Ksh" +  dt.Rows[0][0].ToString()  ;
            Con.Close();
        }

   



        // Retrieve tenants from the database
        private DataTable GetTenants()
        {
            DataTable dtTenants = new DataTable();
            using (SqlDataAdapter sda = new SqlDataAdapter("SELECT Rcode, Tenant FROM BookTbl", Con))
            {
                sda.Fill(dtTenants);
            }
            return dtTenants;
        }


        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Dashboardbtn_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        private void Roombtn_Click(object sender, EventArgs e)
        {
            Rooms Obj = new Rooms();
            Obj.Show();
            this.Hide();
        }

        private void Tenantsbtn_Click(object sender, EventArgs e)
        {
            Tenants Obj = new Tenants();
            Obj.Show();
            this.Hide();
        }

        private void Paymentbtn_Click(object sender, EventArgs e)
        {
            Payments Obj = new Payments();
            Obj.Show();
            this.Hide();
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void IncomeTb_Click(object sender, EventArgs e)
        {

        }

       
        private void chartRevenue_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hostelDbDataSet.BookTbl' table. You can move, or remove it, as needed.
            this.bookTblTableAdapter.Fill(this.hostelDbDataSet.BookTbl);

        }

        private void Loadbtn_Click(object sender, EventArgs e)
        {
            // Example data source: Replace this with your actual database fetch
            DataTable table = new DataTable();
            table.Columns.Add("Tenant", typeof(int));
            table.Columns.Add("Room", typeof(int));
            table.Columns.Add("AmountCalculated", typeof(double));
            table.Columns.Add("Balance", typeof(double));

            // Example: Populate the DataTable with your database values
            table.Rows.Add(1010, 1209, 4500.00, 0.00);
            table.Rows.Add(1005, 1207, 1200.00, -200.00);
            table.Rows.Add(1011, 206, 5000.00, 1000.00);
            table.Rows.Add(1013, 1211, 1400.00, 200.00);

            // Bind the data to the chart
            chartRevenue.DataSource = table;

            // Clear existing series
            chartRevenue.Series.Clear();

            // Add series for "AmountCalculated"
            var seriesAmount = chartRevenue.Series.Add("AmountCalculated");
            seriesAmount.XValueMember = "Tenant";  // X-axis: Tenant
            seriesAmount.YValueMembers = "AmountCalculated";  // Y-axis: AmountCalculated
            seriesAmount.ChartType = SeriesChartType.Column;

            // Add series for "Balance"
            var seriesBalance = chartRevenue.Series.Add("Balance");
            seriesBalance.XValueMember = "Tenant";  // X-axis: Tenant
            seriesBalance.YValueMembers = "Balance";  // Y-axis: Balance
            seriesBalance.ChartType = SeriesChartType.Column;

            // Bind the data to the chart
            chartRevenue.DataBind();
        }



    }
}
