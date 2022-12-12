using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using System.Net.NetworkInformation;

namespace LookInnaBook
{
    public partial class formSignUp : Form
    {
        public formSignUp()
        {
            InitializeComponent();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSignUpNewUser_Click(object sender, EventArgs e)
        {


            SqlConnection myConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LookInnaBook;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            myConnection.Open();
            string username = textBoxUsername.Text; 
            string name = textBoxName.Text;
            string password = textBoxPassword.Text;
            string phoneNumber = textBoxPhoneNumber.Text;
            string address = textBoxAddress.Text;
            string cardNumber = textBoxCreditCardNumber.Text;

            try
            {
                SqlCommand myCommand = new SqlCommand("INSERT INTO users(username,name,password,role,phonenumber,address,cardnumber) VALUES('" + username + "','" + name + "','" + password + "','client','" + phoneNumber + "','" + address + "','" + cardNumber + "');");
                myCommand.Connection = myConnection;
                myCommand.ExecuteReader();
            }
            catch (Exception)
            {
                MessageBox.Show("Username Unavailable!");
            }

            


            myConnection.Close();
        }
    }
}
