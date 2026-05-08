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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Zak_International_Airport
{
    public partial class CUSTOMER_MAIN : Form
    {
        private string loggedInUser;
        private int customerID;

        public CUSTOMER_MAIN(string username)
        {
            InitializeComponent();

            loggedInUser = username;
        }

        public CUSTOMER_MAIN()
        {
            InitializeComponent();
        }

        private void CUSTOMER_MAIN_Load(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "airport";
            string username = "root";
            string password = "";
            string customerTableName = "CUSTOMER";
            string paymentTableName = "PAYMENT";
            string flightTableName = "FLIGHT";
            string connectionString = $"server={server};database={database};username={username};password={password}";
            string customerQuery = $"SELECT * FROM {customerTableName} WHERE UserName = @loggedInUser";
            string paymentQuery = $"SELECT * FROM {paymentTableName} WHERE CUSTOMERID = @customerID";
            string flightQuery = $"SELECT * FROM {flightTableName} WHERE CUSTOMERID = @customerID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    MySqlCommand customerCommand = new MySqlCommand(customerQuery, connection);
                    customerCommand.Parameters.AddWithValue("@loggedInUser", loggedInUser);

                    DataTable customerDataTable = new DataTable();
                    MySqlDataAdapter customerDataAdapter = new MySqlDataAdapter(customerCommand);
                    customerDataAdapter.Fill(customerDataTable);

                    dataGridView1.DataSource = customerDataTable;

                    if (customerDataTable.Rows.Count > 0)
                    {
                        int customerID = Convert.ToInt32(customerDataTable.Rows[0]["CUSTOMERID"]);

                        MySqlCommand paymentCommand = new MySqlCommand(paymentQuery, connection);
                        paymentCommand.Parameters.AddWithValue("@customerID", customerID);

                        DataTable paymentDataTable = new DataTable();
                        MySqlDataAdapter paymentDataAdapter = new MySqlDataAdapter(paymentCommand);
                        paymentDataAdapter.Fill(paymentDataTable);

                        dataGridView2.DataSource = paymentDataTable;
                    }

                    if (customerDataTable.Rows.Count > 0)
                    {
                        int customerID = Convert.ToInt32(customerDataTable.Rows[0]["CUSTOMERID"]);

                        MySqlCommand flightCommand = new MySqlCommand(flightQuery, connection);
                        flightCommand.Parameters.AddWithValue("@customerID", customerID);

                        DataTable flightDataTable = new DataTable();
                        MySqlDataAdapter flightDataAdapter = new MySqlDataAdapter(flightCommand);
                        flightDataAdapter.Fill(flightDataTable);

                        dataGridView3.DataSource = flightDataTable;
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
        }

        private void BUTTON_EXIT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BUTTON_NEW_PAYMENT_Click(object sender, EventArgs e)
        {
            this.Hide();
            FORM_NEW_CARD f5 = new FORM_NEW_CARD(loggedInUser, customerID);
            f5.ShowDialog();
        }

        private void BUTTON_NEW_FLIGHT_Click(object sender, EventArgs e)
        {
            this.Hide();
            FORM_NEW_FLIGHT f6 = new FORM_NEW_FLIGHT(loggedInUser, customerID);
            f6.ShowDialog();
        }
    }
}