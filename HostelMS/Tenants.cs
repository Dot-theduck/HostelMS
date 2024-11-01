using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HostelMS
{
    public partial class Tenants : Form
    {
        public Tenants()
        {
            InitializeComponent();
            ShowTenants();
            CustomizeDataGridView();
        }
        //connects to database
        SqlConnection Con = new SqlConnection(@"Data Source=DOTTHEDUCK;Initial Catalog=HostelDb;Integrated Security=True;");
                // Method to customize the DataGridView appearance
        private void CustomizeDataGridView()
        {
            // Set alternating row colors for better visibility
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            dataGridView1.AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.Color.Black;

            // Set header style
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.RosyBrown;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            dataGridView1.EnableHeadersVisualStyles = false;

            // Set grid line style
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // Set row and column size
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Set selection color
            dataGridView1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridView1.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

        }
        //method to display tenants in the datagridview
        private void ShowTenants()
        {
            try
            {
                Con.Open();
                string Query = "SELECT * FROM TenantTbl";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        //method to reset name,phone and gender fields
        private void ResetData()
        {
            PhoneTb.Text = "";
            GenCb.SelectedIndex = -1;
            TNameTb.Text = "";
            Key = 0;
        }


        // Event handler for selecting a row in the DataGridView
        int Key = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                TNameTb.Text = row.Cells[1].Value.ToString();
                PhoneTb.Text = row.Cells[2].Value.ToString();
                GenCb.Text = row.Cells[3].Value.ToString();

                Key = Convert.ToInt32(row.Cells[0].Value.ToString());
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select a Tenant to Delete!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM TenantTbl WHERE TenId=@TKey", Con);
                    cmd.Parameters.AddWithValue("@TKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tenant Deleted!");
                    Con.Close();
                    ResetData();
                    ShowTenants();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    Con.Close();
                }
            }
        }
        //to save a new tenant
        private void Save_Click(object sender, EventArgs e)
        {
            if (TNameTb.Text == "" || GenCb.SelectedIndex == -1 || PhoneTb.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO TenantTbl(TenName, TenPhone, TenGen) VALUES(@TN, @TP, @TG)", Con);
                    cmd.Parameters.AddWithValue("@TN", TNameTb.Text);
                    cmd.Parameters.AddWithValue("@TP", PhoneTb.Text);
                    cmd.Parameters.AddWithValue("@TG", GenCb.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tenant Added!");
                    Con.Close();
                    ResetData();
                    ShowTenants();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    Con.Close();
                }
            }
        }

        //to edet an existing tenant
        private void Editbtn_Click(object sender, EventArgs e)
        {
            if (TNameTb.Text == "" || GenCb.SelectedIndex == -1 || PhoneTb.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE TenantTbl SET TenName=@TN, TenPhone=@TP, TenGen=@TG WHERE TenId=@TKey", Con);
                    cmd.Parameters.AddWithValue("@TN", TNameTb.Text);
                    cmd.Parameters.AddWithValue("@TP", PhoneTb.Text);
                    cmd.Parameters.AddWithValue("@TG", GenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tenant Updated!");
                    Con.Close();
                    ResetData();
                    ShowTenants();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    Con.Close();
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Rooms Obj = new Rooms();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Bookings bookings = new Bookings();

            //BookingsForm.Show();
        }

        private void TNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close?", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                this.Close();
            }
        }

        private void Tenants_Load(object sender, EventArgs e)
        {

        }

        private void Dashboardbtn_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        private void Tenantbtn_Click(object sender, EventArgs e)
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
    }
}
