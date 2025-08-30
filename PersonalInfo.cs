using Microsoft.VisualBasic.ApplicationServices;
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

    public partial class PersonalInfo : Form
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

        public PersonalInfo(int userID, string fullName, string userType, string username, string Password, string email, string phoneNo, string address, string dateCreated)
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

        private void PersonalInfo_Load(object sender, EventArgs e)
        {
            customerName.Text = FullNameOfCustomer;
            label10.Text = CustomerID.ToString();
            label11.Text = UserType;
            label12.Text = username;
            label13.Text = password;
            label14.Text = email;
            label15.Text = phoneNo;
            label16.Text = address;
            label17.Text = dateCreated;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
