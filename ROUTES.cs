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
    public partial class ROUTES : Form
    {
        public ROUTES()
        {
            InitializeComponent();
        }

        private void BUTTON_EXIT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ROUTES_Load(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "airport";
            string username = "root";
            string password = "";
            string routeTableName = "ROUTE";
            string connectionString = $"server={server};database={database};username={username};password={password}";
            string routeQuery = $"SELECT * FROM {routeTableName}";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    MySqlCommand routeCommand = new MySqlCommand(routeQuery, connection);

                    DataTable routeDataTable = new DataTable();
                    MySqlDataAdapter routeDataAdapter = new MySqlDataAdapter(routeCommand);
                    routeDataAdapter.Fill(routeDataTable);

                    dataGridView1.DataSource = routeDataTable;
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
