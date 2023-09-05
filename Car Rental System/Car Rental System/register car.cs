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
    public partial class register_car : Form
    {
        public register_car()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Car Rental System\Car Rental System\Car Rental System\cardatabase.mdf;Integrated Security=True");

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            AfterLogin afterlogin = new AfterLogin();
            afterlogin.Show();
            this.Hide();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            try
            {
                string Brand = txtbrand.Text;
                string Address = txtaddress.Text;
                string Telephone_No = txttelephoneno.Text;
                string Email = txtemail.Text;
                string Condition = txtcondition.Text;
                string Colour = txtcolour.Text;
                

                string query_insert = "insert into Car_data values('"+Brand+"','"+Address+"','"+Telephone_No+"','"+Email+"','"+Condition+"','"+Colour+"')";

                SqlCommand cmnd = new SqlCommand(query_insert, con);

                con.Open();

                cmnd.ExecuteNonQuery();

                MessageBox.Show("Registration Complete !");

                //Clearing textboxes

                txtbrand.Clear();
                txtaddress.Clear();
                txttelephoneno.Clear();
                txtemail.Clear();
                txtcondition.Clear();
                txtcolour.Clear();


            }
            catch(Exception ex)
            {

                MessageBox.Show("Registration Failed !" + ex);

            }
            finally
            {

                con.Close();
            
            }

        }

        private void txtcondition_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtcondition.Text == "New/Used")
            {
                txtcondition.Clear();
            }
        }

        private void txtcondition_TextChanged(object sender, EventArgs e)
        {
            ///null
        }

        private void txtcolour_MouseClick(object sender, MouseEventArgs e)
        {
            ///null
            
        }

        private void txtcolour_TextChanged(object sender, EventArgs e)
        {
            ///null
        }
    }
}
