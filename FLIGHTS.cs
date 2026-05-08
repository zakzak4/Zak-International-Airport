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
    public partial class FLIGHTS : Form
    {
        public FLIGHTS()
        {
            InitializeComponent();
        }

        private void BUTTON_EXIT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FLIGHTS_Load(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "airport";
            string username = "root";
            string password = "";
            string flightTableName = "FLIGHT";
            string connectionString = $"server={server};database={database};username={username};password={password}";
            string flightQuery = $"SELECT * FROM {flightTableName}";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    MySqlCommand flightCommand = new MySqlCommand(flightQuery, connection);

                    DataTable flightDataTable = new DataTable();
                    MySqlDataAdapter flightDataAdapter = new MySqlDataAdapter(flightCommand);
                    flightDataAdapter.Fill(flightDataTable);

                    dataGridView1.DataSource = flightDataTable;
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
    }
}
