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
    public partial class AfterLogin : Form
    {
        public AfterLogin()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();


        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 loginform = new Form1();
            loginform.Show();
            this.Hide();
        }

        private void btnregistercar_Click(object sender, EventArgs e)
        {
            register_car registercar = new register_car();
            registercar.Show();
            this.Hide();
        }

        private void btnfindcar_Click(object sender, EventArgs e)
        {
            Findacar find_a_car = new Findacar();
            find_a_car.Show();
            this.Hide();
        }

        private void btnregisteruser_Click(object sender, EventArgs e)
        {
            registeruser register_user = new registeruser();
            register_user.Show();
            this.Hide();
        }

        private void btnfinduser_Click(object sender, EventArgs e)
        {
            findauser find_a_user = new findauser();
            find_a_user.Show();
            this.Hide();
        }
    }
}
