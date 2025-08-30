using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Library
{
    public partial class CustomerForm : Form
    {
        private int CustomerID; // To store the logged-in customer's ID
        private string FullNameOfCustomer;
        private string UserType;
        private string username;
        private string password;
        private string email;
        private string phoneNo;
        private string address;
        private string dateCreated;




        public CustomerForm(int userID, string fullName, string userType, string username, string Password, string email, string phoneNo, string address, string dateCreated)
        {
            InitializeComponent();
            this.CustomerID = userID;  // Store the Customer ID
            this.FullNameOfCustomer = fullName;
            this.email = email;
            this.phoneNo = phoneNo;
            this.dateCreated = dateCreated;
            this.username = username;
            this.password = Password;
            this.UserType = userType;
            this.address = address;
        }

        private void DisplayBooks_Click(object sender, EventArgs e)
        {

        }

        private void CustomerForm_Load_1(object sender, EventArgs e)
        {
            lblGreeting.Text = $"Hello {FullNameOfCustomer}!"; // Set the label text
        }

        private void ViewPersonalInfo_Click(object sender, EventArgs e)
        {
           using (var PersonalInfo = new PersonalInfo(CustomerID, FullNameOfCustomer, UserType, username, password, email, phoneNo, address, dateCreated))
            {
                PersonalInfo.ShowDialog();
            }
        }
    }
}
