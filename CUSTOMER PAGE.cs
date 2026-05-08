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
using MySqlX.XDevAPI.Relational;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Zak_International_Airport
{
    public partial class FORM_CUSTOMER : Form
    {
        public FORM_CUSTOMER()
        {
            InitializeComponent();
            GROUPBOX_CUSTLOGIN.BackColor = Color.FromArgb(125, Color.Black);
            GROUPBOX_CUSNEWACC.BackColor = Color.FromArgb(125, Color.Black);
        }
        string c_username, c_password;

        //GLOBAL VARIABLES
        public static string server = "localhost";
        public static string database = "airport";
        public static string username = "root";
        public static string password = "";
        public static string TABLE = "customer";

        private void BUTTON_LOGIN_Click(object sender, EventArgs e)
        {
            string TABLE = "airport.CUSTOMER";
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
                    string Username = MyReader.GetString(3).ToLower();
                    string Password = MyReader.GetString(4).ToLower();

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

                    CUSTOMER_MAIN f4 = new CUSTOMER_MAIN(TEXTBOX_USERNAME.Text);
                    f4.ShowDialog();
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
        public int CountTableRows(string TABLE)
        {
            string MySQLConnectionString = "datasource=localhost;port=3306;username=root;password=;database=airport;";
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

        private void BUTTON_SIGNUP_Click(object sender, EventArgs e)
        {
            string id = null;
            string fname = TEXTBOX_NEW_FIRSTNAME.Text;
            string sname = TEXTBOX_NEW_SURNAME.Text;
            int age = int.Parse(TEXTBOX_NEW_AGE.Text);
            string usname = TEXTBOX_NEW_USERNAME.Text;
            string uspass = TEXTBOX_NEW_PASSWORD.Text;
            string new_gender = TEXTBOX_NEW_GENDER.Text;
            string new_address = TEXTBOX_NEW_ADDRESS.Text;

            string query = "INSERT INTO " + database + "." + TABLE + "(CUSTOMERID, Firstname, Lastname, UserName, UserPassword, Age, Gender, Address) VALUES(@id, @fname, @sname, @usname, @uspass, @age, @new_gender, @new_address)";
            string selectQuery = "SELECT * FROM " + database + "." + TABLE + " WHERE UserName = @usname";

            string mySqlConnectionString = "datasource=" + server + ";port=3306;username=" + c_username + ";password=" + c_password + ";database=" + database;

            using (MySqlConnection connection = new MySqlConnection(mySqlConnectionString))
            {
                connection.Open();

                MySqlCommand insertCommand = new MySqlCommand(query, connection);
                insertCommand.Parameters.AddWithValue("@id", id);
                insertCommand.Parameters.AddWithValue("@fname", fname);
                insertCommand.Parameters.AddWithValue("@sname", sname);
                insertCommand.Parameters.AddWithValue("@usname", usname);
                insertCommand.Parameters.AddWithValue("@uspass", uspass);
                insertCommand.Parameters.AddWithValue("@age", age);
                insertCommand.Parameters.AddWithValue("@new_gender", new_gender);
                insertCommand.Parameters.AddWithValue("@new_address", new_address);

                int rowsAffected = insertCommand.ExecuteNonQuery();
                Console.WriteLine("{0} rows affected!", rowsAffected);

                MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
                selectCommand.Parameters.AddWithValue("@usname", usname);

                MySqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read())
                {
                    string customerId = reader.GetString("CUSTOMERID");
                    string firstName = reader.GetString("Firstname");
                    string lastName = reader.GetString("Lastname");
                    string username = reader.GetString("UserName");
                    int userAge = reader.GetInt32("Age");
                    string gender = reader.GetString("Gender");
                    string address = reader.GetString("Address");

                    Toast message = new Toast();
                    message.ToastMessage("Account Was Created Successfully!");

                    this.Hide();
                    CUSTOMER_MAIN f4 = new CUSTOMER_MAIN(TEXTBOX_NEW_USERNAME.Text);
                    f4.ShowDialog();
                }
                reader.Close();
            }
        }

        private void BUTTON_EXIT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TEXTBOX_PASSWORD_TextChanged(object sender, EventArgs e)
        {
            this.TEXTBOX_PASSWORD.PasswordChar = '*';
        }

        private void TEXTBOX_NEW_PASSWORD_TextChanged(object sender, EventArgs e)
        {
            this.TEXTBOX_NEW_PASSWORD.PasswordChar = '*';
        }

        private void FORM_CUSTOMER_Load(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "airport";
            c_username = "root";
            c_password = "";
            string Query = "Select * from airport.CUSTOMER";
            string MySQLConnectionString = "datasource=" + server + ";port=3306;username=" + c_username + ";password=" + c_password + ";database=" + database + ";";
            MySqlConnection connection = new MySqlConnection(MySQLConnectionString);
            MySqlCommand command = new MySqlCommand(Query, connection);
            command.CommandTimeout = 60;
        }
    }
}