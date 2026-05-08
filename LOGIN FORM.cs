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
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Zak_International_Airport
{
    public partial class FORM_LOGIN : Form
    {
        public FORM_LOGIN()
        {
            InitializeComponent();
            GROUPBOX_STAFF.BackColor = Color.FromArgb(125, Color.Black);
            GROUPBOX_CUST.BackColor = Color.FromArgb(125, Color.Black);
        }

        string username, password;

        private void BUTTON_EXIT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "airport";
            username = "root";
            password = "";
            string Query = "Select * from airport.logintable";
            string MySQLConnectionString = "datasource=" + server + ";port=3306;username=" + username + ";password=" + password + ";database=" + database + ";";
            MySqlConnection connection = new MySqlConnection(MySQLConnectionString);
            MySqlCommand command = new MySqlCommand(Query, connection);
            command.CommandTimeout = 60;

            try
            {
                connection.Open();
                MySqlDataReader MyReader = command.ExecuteReader();
                if (MyReader.HasRows)
                {
                    Toast message = new Toast();
                    message.ToastMessage("You Have Connected Successfully To The Database.");
                }
            }
            catch (Exception ex)
            {
                Toast message = new Toast();
                message.ToastMessage(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        static MySqlConnection DatabaseInit(string connectionString)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            if (connection.State == ConnectionState.Open)
            {
                Toast message = new Toast();
                message.ToastMessage("Connection Opened!");
                return connection;
            }
            else
            {
                Toast message = new Toast();
                message.ToastMessage("Connection Could Not Open!");
                return null;
            }
        }

        private void BUTTON_LOGIN_Click(object sender, EventArgs e)
        {
            string TABLE = "airport.logintable";
            int TableRows = CountTableRows(TABLE);
            string Query = "Select * from " + TABLE;
            string MySQLConnectionString = "datasource=localhost;port=3306;username=root;password=;database=logindatabase;";
            MySqlConnection connection = new MySqlConnection(MySQLConnectionString);
            MySqlCommand command = new MySqlCommand(Query, connection);

            connection.Open();
            MySqlDataReader MyReader = command.ExecuteReader();

            int LoginFlag = 0;
            if (MyReader.HasRows)
            {
                for (int j = 0; j < TableRows; j++)
                {

                    for (int i = 0; i < j + 1; i++)
                    {
                        MyReader.Read();
                    }
                    string Username = MyReader.GetString(4).ToLower();
                    string Password = MyReader.GetString(5).ToLower();

                    if (Username == this.TEXTBOX_USERNAME.Text.ToLower() && Password == this.TEXTBOX_PASSWORD.Text.ToLower())
                    {

                        LoginFlag = 1;
                        break;
                    }
                    else LoginFlag = 0;
                }

                if (LoginFlag == 1)
                {
                    Toast message = new Toast();
                    message.ToastMessage("Login Successful!");
                    this.Hide();
                    FORM_STAFF f2 = new FORM_STAFF();
                    f2.ShowDialog();
                }
                else
                {
                    Toast message = new Toast();
                    message.ToastMessage("Credentials Are Incorrect.");
                    this.TEXTBOX_USERNAME.Text = "";
                    this.TEXTBOX_PASSWORD.Text = "";
                }
            }
            else
            {
                Toast message = new Toast();
                message.ToastMessage("ERROR! No Data Found In The Table!");
            }
            connection.Close();

        }

        private void BUTTON_GU_LOGIN_Click(object sender, EventArgs e)
        {
            this.Hide();
            FORM_CUSTOMER f3 = new FORM_CUSTOMER();
            f3.ShowDialog();
        }

        private void TEXTBOX_PASSWORD_TextChanged(object sender, EventArgs e)
        {
            this.TEXTBOX_PASSWORD.PasswordChar = '*';
        }

        public int CountTableRows(string TABLE)
        {
            string MySQLConnectionString = "datasource=localhost;port=3306;username=root;password=;database=logindatabase;";
            string Query = "Select * from " + TABLE;
            MySqlConnection connection = new MySqlConnection(MySQLConnectionString);
            MySqlCommand command = new MySqlCommand(Query, connection);
            connection.Open();
            MySqlDataReader MyReader = command.ExecuteReader();
            int count = 0;
            while (MyReader.Read())
            {
                count++;
            }
            connection.Close();
            return count;
        }
    }
}