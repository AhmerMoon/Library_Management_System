using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string input = Username.Text.Trim();
            string password = Password.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username/email and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Connection string to your Oracle database
            string connectionString = "User Id = sys; Password = ahmer28704; Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVICE_NAME = xe))); DBA Privilege = SYSDBA; ";

            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();

                    // Determine if input is an email (contains '@') or username
                    string query;
                    if (input.Contains("@"))
                    {
                        query = "SELECT UserID, UserType, FullName FROM Users WHERE Email = :Input AND Password = :Password";
                    }
                    else
                    {
                        query = "SELECT UserID, UserType, FullName FROM Users WHERE Username = :Input AND Password = :Password";
                    }

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.Add(new OracleParameter("Input", input));
                        command.Parameters.Add(new OracleParameter("Password", password));

                        // Execute query
                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string userType = reader["UserType"].ToString();
                                string fullName = reader["FullName"].ToString();
                                int userID = Convert.ToInt32(reader["UserID"]); // Store the UserID

                                if (userType == "Librarian")
                                {
                                    using (var librarian = new Form1(userID, fullName))
                                    {
                                        librarian.ShowDialog();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("User type not recognized.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid username/email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
