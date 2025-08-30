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
    public partial class MainLoginForm : Form
    {
        public MainLoginForm()
        {
            InitializeComponent();
        }


        private void btnLoginAsCustomer_Click(object sender, EventArgs e)
        {
            using (var customer = new CustomerLogin())
            {
                customer.ShowDialog();
            }
        }

        private void btnLoginAsAdmin_Click(object sender, EventArgs e)
        {
            
                using (var admin = new Login())
                {
                    admin.ShowDialog();  
                }
           
        }
    }


}
