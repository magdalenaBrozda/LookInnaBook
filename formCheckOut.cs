using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LookInnaBook
{
    public partial class formCheckOut : Form
    {
        private Client client;

        public formCheckOut(Client valClient)
        {
            
           InitializeComponent();

           client = valClient;

           SqlConnection myConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LookInnaBook;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
           myConnection.Open();

           SqlCommand myCommand = new SqlCommand("SELECT * FROM shoppingCartItems WHERE username='" + client.username + "'");

           myCommand.Connection = myConnection;

           SqlDataReader myReader = myCommand.ExecuteReader();

            
           while (myReader.Read())
           {
               IDataRecord item = ((IDataRecord)myReader);
               String username = item[0].ToString();
               String isbn = item[1].ToString();
               String quantity = item[2].ToString();

            }








        }

       
    }
}
