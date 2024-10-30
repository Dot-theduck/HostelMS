using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HostelMS
{
    public partial class Bookings : Form
    {
        public Bookings()
        {
            InitializeComponent();
            ShowPayments();
            CustomizeDataGridView();
            LoadTenants();
            LoadRooms();
        }

        // Connect to the database
        SqlConnection Con = new SqlConnection(@"Data Source=DOTTHEDUCK;Initial Catalog=HostelDb;Integrated Security=True;");

        // Method to customize the DataGridView appearance
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

        // Method to display payments in the DataGridView
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
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
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


        // Method to reset form fields
        private void ResetData()
        {
            TName.SelectedIndex = -1;
            RName.SelectedIndex = -1;
            FromDt.Text = "";
            AmountToPay.Text = "";
            AmountToReceive.Text = "";
            numericUpDownMonths.Value = 1;
            Key = 0;
        }

        int Key = 0;

        private void dataGridBox_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        // Method to retrieve tenants from the database
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

        // Method to retrieve rooms from the database
        private DataTable GetRooms()
        {
            DataTable dtRooms = new DataTable();
            using (SqlDataAdapter sda = new SqlDataAdapter("SELECT Rnum, RoName, RoCost FROM RoomTbl", Con))
            {
                sda.Fill(dtRooms);
            }
            return dtRooms;
        }

        // Retrieve room cost and calculate total amount based on selected period
        private void RName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RName.SelectedValue != null)
            {
                int roomID = (int)RName.SelectedValue;

                // Retrieve RoCost and Rnum from RoomTbl
                decimal roomCost = GetRoomCost(roomID);

                // Calculate AmountToPaid (roomCost * number of months)
                int months = (int)numericUpDownMonths.Value;
                decimal amountToBePaid = roomCost * months;

                // Display the calculated amount in the TextBox (now AmountToPaid)
                AmountToPay.Text = amountToBePaid.ToString();
            }
        }

        // Method to retrieve room cost based on room ID
        private decimal GetRoomCost(int roomID)
        {
            decimal roomCost = 0;
            using (SqlCommand cmd = new SqlCommand("SELECT RoCost FROM RoomTbl WHERE Rnum = @RoomID", Con))
            {
                cmd.Parameters.AddWithValue("@RoomID", roomID);
                Con.Open();
                roomCost = (decimal)cmd.ExecuteScalar();
                Con.Close();
            }
            return roomCost;
        }

        // Method to add a new booking
        // In AddBtn_Click, make sure you're handling the types properly.
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (TName.SelectedValue == null || RName.SelectedValue == null || FromDt.Text == "")
            {
                MessageBox.Show("Missing Information!");
                return;
            }

            try
            {
                Con.Open();

                // Check if tenant already has a booking
                SqlCommand checkTenantCmd = new SqlCommand("SELECT COUNT(*) FROM BookTbl WHERE Tenant = @Tenant", Con);
                checkTenantCmd.Parameters.AddWithValue("@Tenant", (int)TName.SelectedValue);

                int tenantCount = (int)checkTenantCmd.ExecuteScalar();

                if (tenantCount > 0)
                {
                    MessageBox.Show("This tenant already has a room booked.");
                    Con.Close();
                    return;
                }

                // Check if room is already assigned to another tenant
                SqlCommand checkRoomCmd = new SqlCommand("SELECT COUNT(*) FROM BookTbl WHERE Room = @Room", Con);
                checkRoomCmd.Parameters.AddWithValue("@Room", (int)RName.SelectedValue);

                int roomCount = (int)checkRoomCmd.ExecuteScalar();

                if (roomCount > 0)
                {
                    MessageBox.Show("This room is already assigned to another tenant.");
                    Con.Close();
                    return;
                }

                // If both checks pass, proceed with booking
                SqlCommand cmd = new SqlCommand("INSERT INTO BookTbl (Tenant, Room, PeriodFrom, PeriodTo, AmountCalculated, AmountPaid) " +
                                                "VALUES (@Tenant, @Room, @PeriodFrom, @PeriodTo, @AmountCalculated, @AmountPaid)", Con);

                cmd.Parameters.AddWithValue("@Tenant", (int)TName.SelectedValue);
                cmd.Parameters.AddWithValue("@Room", (int)RName.SelectedValue);

                // Set the booking period
                cmd.Parameters.AddWithValue("@PeriodFrom", FromDt.Value);
                DateTime periodTo = FromDt.Value.AddMonths((int)numericUpDownMonths.Value);
                cmd.Parameters.AddWithValue("@PeriodTo", periodTo);

                // Set calculated and paid amounts
                cmd.Parameters.AddWithValue("@AmountCalculated", decimal.Parse(AmountToPay.Text));
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


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Bookings_Load(object sender, EventArgs e)
        {

        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close?", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
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
                    cmd.Parameters.AddWithValue("@AmountCalculated", decimal.Parse(AmountToPay.Text));
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


        private void DeleteBtn_Click(object sender, EventArgs e)
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

        private void RName_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
