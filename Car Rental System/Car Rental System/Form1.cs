using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtusername_MouseClick(object sender, MouseEventArgs e)
        {
            
            
        }

        private void txtpassword_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AfterLogin afterlogin = new AfterLogin();
            afterlogin.Show();
            this.Hide();
        }
    }
}
