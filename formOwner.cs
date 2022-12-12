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

namespace LookInnaBook
{
    public partial class formOwner : Form
    {
        public formOwner()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LookInnaBook;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            myConnection.Open();

            String isbn = textBoxISBN.Text; 
            String title = textBoxTitle.Text;   
            string genre = textBoxGenre.Text;   
            string numpages = textBoxNumPages.Text; 
            string price = textBoxPrice.Text;
            string author = textBoxAuthor.Text;
            string publisher = textBoxPublisher.Text;
            string salespercentage = textBoxSalesPercentage.Text;
            string quantity = textBoxQuantity.Text; 

            
            SqlCommand myCommand = new SqlCommand("INSERT INTO storeinventory (isbn,title,genre,numpages,price,author,publisher,salespercentage,copiesinstore,copiessold) VALUES ('" + isbn + "','" + title + "','" + genre + "','" + numpages + "','" + price + "','" + author + "','" + publisher + "','" + salespercentage + "','" + quantity + "'," + 0 + ");");
            myCommand.Connection = myConnection;

           
            myCommand.ExecuteReader();

           
            myConnection.Close();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LookInnaBook;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            myConnection.Open();

            String isbn = textBoxISBN.Text;
            string quantity = textBoxQuantity.Text;

          
            SqlCommand myCommand = new SqlCommand("SELECT * FROM storeinventory WHERE isbn = " + isbn);
            myCommand.Connection = myConnection;

            SqlDataReader myReader = myCommand.ExecuteReader();

           
            int newQuantity = 0;

      
            if (myReader.HasRows)
            {
                myReader.Read();

                IDataRecord myIDataRecord = ((IDataRecord)myReader);
                String isbnReturned = myIDataRecord[0].ToString();
                string quantityReturned = myIDataRecord[8].ToString();

                int quantityInt = int.Parse(quantity);
                int quantity2Int = int.Parse(quantityReturned);

                if (isbn == isbnReturned)
                {
                    newQuantity = quantity2Int - quantityInt;
                }

                if (newQuantity < 0)
                {
                    newQuantity = 0;
                }
            }

        
            myReader.Close();

            SqlCommand mySecondCommand = new SqlCommand("UPDATE storeinventory SET copiesinstore =" + newQuantity + " WHERE isbn ='" + isbn + "'");
            mySecondCommand.Connection = myConnection;
            SqlDataReader mySecondReader = mySecondCommand.ExecuteReader();

            myConnection.Close();
        }

    }
}
