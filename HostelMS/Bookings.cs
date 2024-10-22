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
                string Query = "SELECT * FROM BookTbl";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
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
            }
            else
            {
                try
                {
                    Con.Open();

                    // Make sure that @PeriodFrom is a DateTime value
                    SqlCommand cmd = new SqlCommand("INSERT INTO BookTbl (Tenant, Room, PeriodFrom, PeriodTo, AmountCalculated, AmountPaid) " +
                                                    "VALUES (@Tenant, @Room, @PeriodFrom, @PeriodTo, @AmountCalculated, @AmountPaid)", Con);

                    cmd.Parameters.AddWithValue("@Tenant", (int)TName.SelectedValue);
                    cmd.Parameters.AddWithValue("@Room", (int)RName.SelectedValue);

                    // Ensure this is a DateTime value
                    cmd.Parameters.AddWithValue("@PeriodFrom", FromDt.Value);

                    // PeriodTo could be calculated as a future date, based on the number of months selected
                    DateTime periodTo = FromDt.Value.AddMonths((int)numericUpDownMonths.Value);
                    cmd.Parameters.AddWithValue("@PeriodTo", periodTo);

                    // Ensure AmountCalculated and AmountPaid are decimals
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
    }
}
