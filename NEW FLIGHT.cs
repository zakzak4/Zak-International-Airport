using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Zak_International_Airport
{
    public partial class FORM_NEW_FLIGHT : Form
    {
        private string loggedInUser;
        private string connectionString;
        private int customerID;

        public FORM_NEW_FLIGHT(string username, int customerID)
        {
            InitializeComponent();

            loggedInUser = username;
            connectionString = "server=localhost;database=airport;username=root;password=";

            this.customerID = customerID;

            GROUPBOX_NEW_FLIGHT.BackColor = Color.FromArgb(125, Color.Black);
        }

        private void BUTTON_ADD_FLIGHT_Click(object sender, EventArgs e)
        {
            string planeBrand = TEXTBOX_FCOMP.Text;
            int planeSeat = Convert.ToInt32(TEXTBOX_SEAT.Text);
            string originAirport = TEXTBOX_FROM_AIRPORT.Text;
            string destAirport = TEXTBOX_TO_AIRPORT.Text;

            string insertQuery = "INSERT INTO FLIGHT (PlaneBrand, PlaneSeat, OriginAirport, DestAirport, CUSTOMERID, STAFFID) " +
                                 "VALUES (@planeBrand, @planeSeat, @originAirport, @destAirport, @customerID, @staffID)";

            string selectCustomerIDQuery = "SELECT CUSTOMERID FROM CUSTOMER WHERE UserName = @loggedInUser";

            string selectRandomStaffIDQuery = "SELECT STAFFID FROM STAFF ORDER BY RAND() LIMIT 1";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    MySqlCommand selectCustomerIDCommand = new MySqlCommand(selectCustomerIDQuery, connection);
                    selectCustomerIDCommand.Parameters.AddWithValue("@loggedInUser", loggedInUser);

                    int customerID = Convert.ToInt32(selectCustomerIDCommand.ExecuteScalar());

                    MySqlCommand selectRandomStaffIDCommand = new MySqlCommand(selectRandomStaffIDQuery, connection);
                    int staffID = Convert.ToInt32(selectRandomStaffIDCommand.ExecuteScalar());

                    MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@planeBrand", planeBrand);
                    insertCommand.Parameters.AddWithValue("@planeSeat", planeSeat);
                    insertCommand.Parameters.AddWithValue("@originAirport", originAirport);
                    insertCommand.Parameters.AddWithValue("@destAirport", destAirport);
                    insertCommand.Parameters.AddWithValue("@customerID", customerID);
                    insertCommand.Parameters.AddWithValue("@staffID", staffID);

                    int rowsAffected = insertCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Toast message = new Toast();
                        message.ToastMessage("Flight Added Successfully!");
                    }
                    else
                    {
                        Toast message = new Toast();
                        message.ToastMessage("Failed To Add Flight!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            this.Hide();
            FORM_CUSTOMER f3 = new FORM_CUSTOMER();
            f3.ShowDialog();
        }

        private void BUTTON_EXIT_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}