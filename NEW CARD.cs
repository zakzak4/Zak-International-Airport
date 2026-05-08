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
    public partial class FORM_NEW_CARD : Form
    {
        private string loggedInUser;
        private string connectionString;
        private int customerID;

        public FORM_NEW_CARD(string username, int customerID)
        {
            InitializeComponent();

            loggedInUser = username;
            connectionString = "server=localhost;database=airport;username=root;password=";

            this.customerID = customerID;

            GROUPBOX_NEW_CARD.BackColor = Color.FromArgb(125, Color.Black);
        }

        private void BUTTON_EXIT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BUTTON_ADD_CARD_Click(object sender, EventArgs e)
        {
            string cardType = TEXTBOX_CTYPE.Text;
            string cardNumber = TEXTBOX_CNUM.Text;
            string expireDate = TEXTBOX_CDATE.Text;


            string insertQuery = "INSERT INTO PAYMENT (Cardtype, Cardnumber, Expiredate, CUSTOMERID) " +
                                 "VALUES (@cardType, @cardNumber, @expireDate, @customerID)";

            string selectCustomerIDQuery = "SELECT CUSTOMERID FROM CUSTOMER WHERE UserName = @loggedInUser";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    MySqlCommand selectCustomerIDCommand = new MySqlCommand(selectCustomerIDQuery, connection);
                    selectCustomerIDCommand.Parameters.AddWithValue("@loggedInUser", loggedInUser);

                    int customerID = Convert.ToInt32(selectCustomerIDCommand.ExecuteScalar());

                    MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@cardType", cardType);
                    insertCommand.Parameters.AddWithValue("@cardNumber", cardNumber);
                    insertCommand.Parameters.AddWithValue("@expireDate", expireDate);
                    insertCommand.Parameters.AddWithValue("@customerID", customerID);

                    int rowsAffected = insertCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Toast message = new Toast();
                        message.ToastMessage("Card Added Successfully!");
                    }
                    else
                    {
                        Toast message = new Toast();
                        message.ToastMessage("Failed To Add Card!");
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
    }
}