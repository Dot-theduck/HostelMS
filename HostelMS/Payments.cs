using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HostelMS
{
    public partial class Payments : Form
    {
        public Payments()
        {
            InitializeComponent();
            ShowPayments();
            CustomizeDataGridView();
            LoadTenants();
            LoadRooms();
        }

        // Connection to the database
        SqlConnection Con = new SqlConnection(@"Data Source=DOTTHEDUCK;Initial Catalog=HostelDb;Integrated Security=True;");

        // Customize DataGridView appearance
        private void CustomizeDataGridView()
        {
            dataGridBox.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            dataGridBox.AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dataGridBox.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.RosyBrown;
            dataGridBox.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dataGridBox.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            dataGridBox.EnableHeadersVisualStyles = false;
            dataGridBox.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridBox.RowTemplate.Height = 30;
            dataGridBox.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridBox.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridBox.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
        }

        // Display payments in the DataGridView
        private void ShowPayments()
        {
            try
            {
                Con.Open();
                string query = @"
                SELECT 
                    b.Rcode,
                    t.TenName AS Tenant,
                    r.RoName AS Room,
                    b.PeriodFrom,
                    b.PeriodTo,
                    r.RoCost AS AmountCalculated,
                    b.AmountPaid,
                    b.Balance
                FROM 
                    BookTbl b
                INNER JOIN 
                    TenantTbl t ON b.Tenant = t.TenID
                INNER JOIN 
                    RoomTbl r ON b.Room = r.Rnum";

                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridBox.DataSource = ds.Tables[0];
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

        // Reset form fields
        private void ResetData()
        {
            TName.SelectedIndex = -1;
            RName.SelectedIndex = -1;
            FromDt.Text = "";
            AmounttoPay.Text = "";
            AmountToReceive.Text = "";
            numericUpDownMonths.Value = 1;
            Key = 0;
        }

        int Key = 0;

        private void dataGridBox_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridBox.Rows[e.RowIndex];
                TName.Text = row.Cells[1].Value.ToString();
                RName.Text = row.Cells[2].Value.ToString();
                FromDt.Text = row.Cells[3].Value.ToString();
                numericUpDownMonths.Text = row.Cells[4].Value.ToString();
                AmountToReceive.Text = row.Cells[5].Value.ToString();
                Key = Convert.ToInt32(row.Cells[0].Value.ToString());
            }
        }

        // Load tenants into ComboBox (now TName)
        private void LoadTenants()
        {
            DataTable dtTenants = GetTenants();
            TName.DataSource = dtTenants;
            TName.DisplayMember = "TenName";
            TName.ValueMember = "TenID";
        }

        // Retrieve tenants from the database
        private DataTable GetTenants()
        {
            DataTable dtTenants = new DataTable();
            using (SqlDataAdapter sda = new SqlDataAdapter("SELECT TenID, TenName FROM TenantTbl", Con))
            {
                sda.Fill(dtTenants);
            }
            return dtTenants;
        }

        // Load rooms into ComboBox (now RName)
        private void LoadRooms()
        {
            DataTable dtRooms = GetRooms();
            RName.DataSource = dtRooms;
            RName.DisplayMember = "RoName";
            RName.ValueMember = "Rnum";
        }

        // Retrieve rooms from the database
        private DataTable GetRooms()
        {
            DataTable dtRooms = new DataTable();
            using (SqlDataAdapter sda = new SqlDataAdapter("SELECT Rnum, RoName, RoCost FROM RoomTbl", Con))
            {
                sda.Fill(dtRooms);
            }
            return dtRooms;
        }

        // Method to retrieve room cost and calculate total amount
        private void RName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RName.SelectedValue != null)
            {
                int roomID = (int)RName.SelectedValue;
                decimal roomCost = GetRoomCost(roomID);
                int months = (int)numericUpDownMonths.Value;
                decimal amountToBePaid = roomCost * months;
                AmounttoPay.Text = amountToBePaid.ToString();
            }
        }

        // Retrieve room cost based on room ID
        private decimal GetRoomCost(int roomID)
        {
            decimal roomCost = 0;
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT RoCost FROM RoomTbl WHERE Rnum = @RoomID", Con))
                {
                    cmd.Parameters.AddWithValue("@RoomID", roomID);
                    Con.Open();
                    object result = cmd.ExecuteScalar();
                    roomCost = (result != null) ? (decimal)result : 0; // Handle potential null values
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving room cost: " + ex.Message);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
            return roomCost;
        }



        // Method to add a new booking
        private void AddBtn_Click_1(object sender, EventArgs e)
        {
            if (TName.SelectedValue == null || RName.SelectedValue == null || FromDt.Text == "")
            {
                MessageBox.Show("Missing Information!");
                return;
            }

            try
            {
                Con.Open();

                // Check if the selected room is marked as "Taken"
                SqlCommand checkRoomStatusCmd = new SqlCommand("SELECT RoStatus FROM RoomTbl WHERE Rnum = @RoomID", Con);
                checkRoomStatusCmd.Parameters.AddWithValue("@RoomID", (int)RName.SelectedValue);
                string roomStatus = checkRoomStatusCmd.ExecuteScalar()?.ToString();

                if (roomStatus == "Taken")
                {
                    MessageBox.Show("This room is already taken. Please select an available room.");
                    Con.Close();
                    return;
                }

                SqlCommand checkTenantCmd = new SqlCommand("SELECT COUNT(*) FROM BookTbl WHERE Tenant = @Tenant", Con);
                checkTenantCmd.Parameters.AddWithValue("@Tenant", (int)TName.SelectedValue);
                int tenantCount = (int)checkTenantCmd.ExecuteScalar();

                if (tenantCount > 0)
                {
                    MessageBox.Show("This tenant already has a room booked.");
                    Con.Close();
                    return;
                }

                SqlCommand checkRoomCmd = new SqlCommand("SELECT COUNT(*) FROM BookTbl WHERE Room = @Room", Con);
                checkRoomCmd.Parameters.AddWithValue("@Room", (int)RName.SelectedValue);
                int roomCount = (int)checkRoomCmd.ExecuteScalar();

                if (roomCount > 0)
                {
                    MessageBox.Show("This room is already assigned to another tenant.");
                    Con.Close();
                    return;
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO BookTbl (Tenant, Room, PeriodFrom, PeriodTo, AmountCalculated, AmountPaid) " +
                                                "VALUES (@Tenant, @Room, @PeriodFrom, @PeriodTo, @AmountCalculated, @AmountPaid)", Con);

                cmd.Parameters.AddWithValue("@Tenant", (int)TName.SelectedValue);
                cmd.Parameters.AddWithValue("@Room", (int)RName.SelectedValue);
                cmd.Parameters.AddWithValue("@PeriodFrom", FromDt.Value);
                DateTime periodTo = FromDt.Value.AddMonths((int)numericUpDownMonths.Value);
                cmd.Parameters.AddWithValue("@PeriodTo", periodTo);
                cmd.Parameters.AddWithValue("@AmountCalculated", decimal.Parse(AmounttoPay.Text));
                cmd.Parameters.AddWithValue("@AmountPaid", decimal.Parse(AmountToReceive.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Booking Added!");
                Con.Close();
                ResetData();
                ShowPayments();
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

        private void DeleteBtn_Click_1(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select a booking to delete!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM BookTbl WHERE Rcode=@Rcode", Con);
                    cmd.Parameters.AddWithValue("@Rcode", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Booking Deleted!");
                    Con.Close();
                    ResetData();
                    ShowPayments();
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

        private void EditBtn_Click_1(object sender, EventArgs e)
        {
            if (TName.SelectedValue == null || RName.SelectedValue == null || FromDt.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE BookTbl SET Tenant=@Tenant, Room=@Room, PeriodFrom=@PeriodFrom, PeriodTo=@PeriodTo, AmountCalculated=@AmountCalculated, AmountPaid=@AmountPaid WHERE Rcode=@Rcode", Con);

                    cmd.Parameters.AddWithValue("@Tenant", (int)TName.SelectedValue);
                    cmd.Parameters.AddWithValue("@Room", (int)RName.SelectedValue);
                    cmd.Parameters.AddWithValue("@PeriodFrom", FromDt.Value);

                    // Calculate PeriodTo based on number of months selected
                    DateTime periodTo = FromDt.Value.AddMonths((int)numericUpDownMonths.Value);
                    cmd.Parameters.AddWithValue("@PeriodTo", periodTo);

                    // Parse and assign calculated and paid amounts
                    cmd.Parameters.AddWithValue("@AmountCalculated", decimal.Parse(AmounttoPay.Text));
                    cmd.Parameters.AddWithValue("@AmountPaid", decimal.Parse(AmountToReceive.Text));

                    // Set Rcode (primary key) for the booking being edited
                    cmd.Parameters.AddWithValue("@Rcode", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Booking Updated!");

                    Con.Close();
                    ResetData();
                    ShowPayments();
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

        private void CloseBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void Dashboardbtn_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        private void Roomsbtn_Click(object sender, EventArgs e)
        {
            Rooms Obj = new Rooms();
            Obj.Show();
            this.Hide();
        }

        private void Tenantbtn_Click(object sender, EventArgs e)
        {
            Tenants Obj = new Tenants();
            Obj.Show();
            this.Hide();
        }

        private void Paymentsbtn_Click(object sender, EventArgs e)
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

        private void TName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RName_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
