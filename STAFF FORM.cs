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
    public partial class FORM_STAFF : Form
    {
        public FORM_STAFF()
        {
            InitializeComponent();

            GROUPBOX_NEWSTAFF.BackColor = Color.FromArgb(125, Color.Black);
            GROUPBOX_STATUS.BackColor = Color.FromArgb(125, Color.Black);
        }
        string c_username, c_password;

        //GLOBAL VARIABLES
        public static string server = "localhost";
        public static string database = "airport";
        public static string username = "root";
        public static string password = "";
        public static string TABLE = "logintable";

        private void BUTTON_EXIT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TEXTBOX_NEW_PASSWORD_TextChanged(object sender, EventArgs e)
        {
            this.TEXTBOX_NEW_PASSWORD.PasswordChar = '*';
        }

        private void BUTTON_VIEW_FLIGHTS_Click(object sender, EventArgs e)
        {
            FLIGHTS f7 = new FLIGHTS();
            f7.ShowDialog();
        }

        private void BUTTON_VIEW_ROUTES_Click(object sender, EventArgs e)
        {
            ROUTES f8 = new ROUTES();
            f8.ShowDialog();
        }

        private void BUTTON_VIEW_STAFF_Click(object sender, EventArgs e)
        {
            STAFF f9 = new STAFF();
            f9.ShowDialog();
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

            string Query = "INSERT INTO " + database + "." + TABLE + "(logintableID, Firstname, Surname, Age, UserName, UserPassword, Gender) VALUES(@id, @fname, @sname, @age, @usname, @uspass, @new_gender)";

            string MySqlConnectionString = "datasource=" + server + ";port=3306;username=" + username + ";password=" + password + ";database=" + database;


            using (MySqlConnection connection = new MySqlConnection(MySqlConnectionString))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand(Query, connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@fname", fname);
                command.Parameters.AddWithValue("@sname", sname);
                command.Parameters.AddWithValue("@age", age);
                command.Parameters.AddWithValue("@usname", usname);
                command.Parameters.AddWithValue("@uspass", uspass);
                command.Parameters.AddWithValue("@new_gender", new_gender);

                int RowsAffected = command.ExecuteNonQuery();
                Console.WriteLine("{0} rows affected!", RowsAffected);

                Toast message = new Toast();
                message.ToastMessage("Account Created Successfully.");
            }
            this.Hide();
            FORM_LOGIN f1 = new FORM_LOGIN();
            f1.ShowDialog();
        }
    }
}