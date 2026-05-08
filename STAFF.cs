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
    public partial class STAFF : Form
    {
        public STAFF()
        {
            InitializeComponent();
        }

        private void BUTTON_EXIT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void STAFF_Load(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "airport";
            string username = "root";
            string password = "";
            string staffTableName = "STAFF";
            string connectionString = $"server={server};database={database};username={username};password={password}";
            string staffQuery = $"SELECT * FROM {staffTableName}";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    MySqlCommand staffCommand = new MySqlCommand(staffQuery, connection);

                    DataTable staffDataTable = new DataTable();
                    MySqlDataAdapter staffDataAdapter = new MySqlDataAdapter(staffCommand);
                    staffDataAdapter.Fill(staffDataTable);

                    dataGridView1.DataSource = staffDataTable;
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
