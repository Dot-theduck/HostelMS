using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HostelMS
{
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
            ShowRooms();
            CustomizeDataGridView();
            LoadOwners();
        }

        //connects to database
        SqlConnection Con = new SqlConnection(@"Data Source=DOTTHEDUCK;Initial Catalog=HostelDb;Integrated Security=True;");
        // Method to customize the DataGridView appearance
        private void CustomizeDataGridView()
        {
            // Set alternating row colors for better visibility
            dataGridRoom.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            dataGridRoom.AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.Color.Black;

            // Set header style
            dataGridRoom.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.RosyBrown;
            dataGridRoom.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dataGridRoom.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            dataGridRoom.EnableHeadersVisualStyles = false;

            // Set grid line style
            dataGridRoom.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // Set row and column size
            dataGridRoom.RowTemplate.Height = 30;
            dataGridRoom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Set selection color
            dataGridRoom.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridRoom.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

        }

        //method to display rooms in the datagridview
        private void ShowRooms()
        {
            try
            {
                Con.Open();
                string Query = "SELECT * FROM RoomTbl";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridRoom.DataSource = ds.Tables[0];
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
            RNameTb.Text = "";
            TypeCb.SelectedIndex = -1;
            CostCb.Text = "";
            StatusCb.SelectedIndex = -1;
            Key = 0;
        }

        // Event handler for selecting a row in the DataGridView
        int Key = 0;
        private void dataGridRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridRoom.Rows[e.RowIndex];
                RNameTb.Text = row.Cells[1].Value.ToString();
                TypeCb.Text = row.Cells[2].Value.ToString();
                CostCb.Text = row.Cells[3].Value.ToString();
                StatusCb.Text = row.Cells[4].Value.ToString();
            

                Key = Convert.ToInt32(row.Cells[0].Value.ToString());
            }
        }
        // Load owners into ComboBox (OwnerTb)
        private void LoadOwners()
        {
            DataTable dtOwners = GetOwners();
            OwnerTb.DataSource = dtOwners;        // Set the data source for the combobox
            OwnerTb.DisplayMember = "OName";     // The column to display (Owner name)
            OwnerTb.ValueMember = "OID";         // The column to use as the value (Owner ID)
        }

        // Retrieve owners from the database
        private DataTable GetOwners()
        {
            DataTable dtOwners = new DataTable();
            using (SqlDataAdapter sda = new SqlDataAdapter("SELECT OID, OName FROM OwnersTbl", Con))
            {
                sda.Fill(dtOwners);
            }
            return dtOwners;
        }


        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select a Room to Delete!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM RoomTbl WHERE Rnum=@RKey", Con);
                    cmd.Parameters.AddWithValue("@RKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tenant Deleted!");
                    Con.Close();
                    ResetData();
                    ShowRooms();
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

        private void AddRoom_Click(object sender, EventArgs e)
        {

            if (RNameTb.Text == "" || TypeCb.SelectedIndex == -1 || CostCb.Text == "" || StatusCb.SelectedIndex == -1 || OwnerTb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                try
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO RoomTbl (RoName, RoType, RoCost, RoStatus, OID) VALUES (@RN, @RT, @RC, @RS, @OID)", Con);


                    cmd.Parameters.AddWithValue("@RN", RNameTb.Text);               
                    cmd.Parameters.AddWithValue("@RT", TypeCb.SelectedItem.ToString()); 
                    cmd.Parameters.AddWithValue("@RC", CostCb.Text);                
                    cmd.Parameters.AddWithValue("@RS", StatusCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@OID", OwnerTb.SelectedValue);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Room Added!");
                    Con.Close();
                    ResetData();
                    ShowRooms();
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


        private void Editbtn_Click_1(object sender, EventArgs e)
        {
            if (RNameTb.Text == "" || TypeCb.SelectedIndex == -1 || CostCb.Text == "" || StatusCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(
                     "UPDATE RoomTbl SET RoName=@RN, RoType=@RT, RoCost=@RC, RoStatus=@RS, OID=@OID WHERE Rnum=@RKey", Con);

                    cmd.Parameters.AddWithValue("@RN", RNameTb.Text);             
                    cmd.Parameters.AddWithValue("@RT", TypeCb.SelectedItem.ToString()); 
                    cmd.Parameters.AddWithValue("@RC", CostCb.Text);       
                    cmd.Parameters.AddWithValue("@RS", StatusCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@OID", OwnerTb.SelectedValue);
                    cmd.Parameters.AddWithValue("@RKey", Key);                      

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Room Updated!");
                    Con.Close();
                    ResetData();
                    ShowRooms();
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

        private void Closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


  
        private void TypeCb_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
