using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace LookInnaBook
{
    public partial class formLogIn : Form
    {
        public formLogIn()
        {
            InitializeComponent();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            formSignUp signUp = new formSignUp();
            signUp.ShowDialog();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        { 

            SqlConnection myConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LookInnaBook;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            myConnection.Open();
            string username = textBoxUsername.Text; 
            string password = textBoxPassword.Text;
           
            SqlCommand myCommand = new SqlCommand("SELECT * FROM users WHERE username = '" + username + "'");
            myCommand.Connection = myConnection;
        
            SqlDataReader myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                IDataRecord myIDataRecord = ((IDataRecord)myReader);
                String usernameReturned = myIDataRecord[0].ToString();
                String nameReturned = myIDataRecord[1].ToString();
                String passwordReturned = myIDataRecord[2].ToString();
                String roleReturned = myIDataRecord[3].ToString();
                String phonenumberReturned = myIDataRecord[4].ToString();
                String addressReturned = myIDataRecord[5].ToString();
                String cardnumberReturned = myIDataRecord[6].ToString();

                if (passwordReturned == password)
                {
                    if (roleReturned == "owner")
                    {
                        formOwner owner = new formOwner();


                        owner.ShowDialog();

                    }
                    else
                    {

                        Client currentClient = new Client(nameReturned, usernameReturned, passwordReturned,phonenumberReturned, addressReturned, cardnumberReturned);
                        
                        formClient client = new formClient(currentClient);  
                        
                        
                        client.ShowDialog();
                
                    }

                }
                else
                {
                
                    MessageBox.Show("Invalid Username and/or Password");
                }

            }

      
            myConnection.Close();
         
        }
    }
}
