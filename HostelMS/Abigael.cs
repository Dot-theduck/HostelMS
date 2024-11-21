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

namespace HostelMS
{
    public partial class Abigael : Form
    {
        public Abigael()
        {
            InitializeComponent();
            LoadRcodes();
        }

        // Connection to the database
        SqlConnection Con = new SqlConnection(@"Data Source=DOTTHEDUCK;Initial Catalog=HostelDb;Integrated Security=True;");

        // Load Rcodes into the ComboBox
        private void LoadRcodes()
        {
            try
            {
                DataTable dtRcodes = new DataTable();
                Con.Open();
                string query = "SELECT Rcode FROM BookTbl"; // Fetch all Rcodes from BookTbl
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                sda.Fill(dtRcodes);

                Rcode.DataSource = dtRcodes; // Set the data source for the ComboBox
                Rcode.DisplayMember = "Rcode"; // Display the Rcode
                Rcode.ValueMember = "Rcode"; // Value is also Rcode
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


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Rcode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Rcode.SelectedValue != null) // Ensure a value is selected
            {
                int selectedRcode = Convert.ToInt32(Rcode.SelectedValue); // Get the selected Rcode
                ShowBookingDetails(selectedRcode); // Fetch and display booking details
            }
        }

        // Retrieve booking details for the selected Rcode
        private void ShowBookingDetails(int rcode)
        {
            try
            {
                Con.Open();
                string query = @"
                    SELECT 
                        B.Rcode,
                        T.TenName AS TenantName,
                        R.RoName AS Room,
                        R.RoCost AS RoomPrice,
                        B.Balance,
                        B.PeriodTo AS EndDate
                    FROM BookTbl B
                    JOIN TenantTbl T ON B.Tenant = T.TenID
                    JOIN RoomTbl R ON B.Room = R.Rnum
                    WHERE B.Rcode = @Rcode";

                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@Rcode", rcode);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Populate the text boxes with the fetched data
                    FName.Text = reader["TenantName"].ToString(); // Corrected
                    Room.Text = reader["Room"].ToString();       // Corrected
                    Price.Text = reader["RoomPrice"].ToString(); // Corrected
                    Balance.Text = reader["Balance"].ToString(); // Corrected
                    Enddate.Text = Convert.ToDateTime(reader["EndDate"]).ToString("yyyy-MM-dd"); // Corrected
                }
                else
                {
                    MessageBox.Show("No details found for the selected Rcode.");
                }


                reader.Close();
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
   



        

        private void Abigael_Load(object sender, EventArgs e)
        {
            // Trigger Rcode load and initialize event handling
            LoadRcodes();
            Rcode.SelectedIndexChanged += Rcode_SelectedIndexChanged;
        }

       

        
    }
}
