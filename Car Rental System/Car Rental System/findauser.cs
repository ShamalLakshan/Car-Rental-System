using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Car_Rental_System
{
    public partial class findauser : Form
    {
        public findauser()
        {
            InitializeComponent();
        }
        string connectionstring2 = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Car Rental System\Car Rental System\Car Rental System\userdatabase.mdf;Integrated Security=True";

        private void btnback_Click(object sender, EventArgs e)
        {
            AfterLogin afterlogin = new AfterLogin();
            afterlogin.Show();
            this.Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnshowdgv2_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon2 = new SqlConnection(connectionstring2))
            {
                string query2 = "SELECT * FROM Users";
                SqlDataAdapter sda2 = new SqlDataAdapter(query2, sqlcon2);
                DataTable dt2 = new DataTable();
                sda2.Fill(dt2);
                dataGridView2.DataSource = dt2;
                sqlcon2.Close();
            }
        }
    }
}
