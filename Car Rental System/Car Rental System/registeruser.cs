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
    public partial class registeruser : Form
    {
        public registeruser()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Car Rental System\Car Rental System\Car Rental System\userdatabase.mdf;Integrated Security=True");

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

        private void txtgender2_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtgender2.Text == "Male/Female")
            {
                txtgender2.Clear();
            
            }
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            try
            {
                string Name2 = txtname2.Text;
                string Address2 = txtaddress2.Text;
                string Telephone_No2 = txttelephoneno2.Text;
                string Email2 = txtemail2.Text;
                string Gender2 = txtgender2.Text;
                string ID_No2 = txtidno2.Text;

                string insert = "INSERT INTO Users values('"+Name2+"', '"+Address2+"', '"+Telephone_No2+"', '"+Email2+"', '"+Gender2+"', '"+ID_No2+"')";

                SqlCommand command = new SqlCommand(insert, connection);

                connection.Open();

                command.ExecuteNonQuery();

                MessageBox.Show("Registration Complete !");

                //Clearing textboxes

                txtname2.Clear();
                txtaddress2.Clear();
                txttelephoneno2.Clear();
                txtemail2.Clear();
                txtgender2.Clear();
                txtidno2.Clear();


            }
            catch(Exception ex)
            {
                MessageBox.Show("Registration Failed !" + ex);

            }
            finally
            {

                connection.Close();
            
            }

        }
    }
}
