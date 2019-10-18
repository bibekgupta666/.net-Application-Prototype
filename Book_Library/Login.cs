using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Library
{
    public partial class Login : Form
    {
        iUserValidation usermanager = new UserValidationImpl();

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if((txtUsername.Text == "" || txtPassword.Text == ""))
            {
                MessageBox.Show("Please fill up all the Credintials.");
            }
            else
            {
                if(usermanager.UserValiadtion(txtUsername.Text, txtPassword.Text))
                {
                    MessageBox.Show("Welcome User!");

                    Media newForm = new Media();
                    newForm.Show();
                    this.Hide();
                }else
                {
                    MessageBox.Show("Incorrect Username of Password");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
