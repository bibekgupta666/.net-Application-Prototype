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
    public partial class Media : Form
    {
        iMediaManager mediaManger = new MediaManagerImpl();

        public Media()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.dataShow.DataSource = mediaManger.ViewAllMedia();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.dataShow.DataSource = mediaManger.CustomSearch(txtDirector.Text, txtGenre.Text);

            if(mediaManger.CustomSearch(txtDirector.Text, txtGenre.Text) == null)
            {
                MessageBox.Show("No Results Found!");
                this.dataShow.DataSource = mediaManger.ViewAllMedia();
            }
            txtDirector.Text = "";
            txtGenre.Text = "";
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login newForm = new Login();
            newForm.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
