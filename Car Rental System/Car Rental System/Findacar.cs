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
    public partial class Findacar : Form
    {
        public Findacar()
        {
            InitializeComponent();
        }

        string connectionstring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Car Rental System\Car Rental System\Car Rental System\cardatabase.mdf;Integrated Security=True";

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

        private void btnshowdgv_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionstring))
            {
                string query = "SELECT * FROM Car_data";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlcon.Close();

            
            }
        }
    }
}
