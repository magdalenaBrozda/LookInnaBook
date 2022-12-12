using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace LookInnaBook
{
    public partial class formBookDetails : Form
    {

        public formBookDetails(Book valBook, Client valClient)
        {
            client = valClient;

            book = valBook;
            
            InitializeComponent();

            numericUpDown1.Maximum = valBook.copiesinstore;

            label1.Text = valBook.title;
            label2.Text = valBook.author;
            label3.Text = valBook.publisher;
            label4.Text = valBook.genre;
            label5.Text = valBook.numpages.ToString();
            label6.Text = valBook.isbn;
            label7.Text = valBook.copiesinstore.ToString();
            label8.Text = valBook.price.ToString();

            




        }

        private void buttonAddToShoppingCart_Click(object sender, EventArgs e)
        {

            
            SqlConnection myConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LookInnaBook;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            myConnection.Open();

            int yyy = (int)numericUpDown1.Value;
            string username =client.username;
           string isbn =  book.isbn;

    

            SqlCommand myCommand = new SqlCommand("INSERT INTO shoppingCartItems(username,isbn,quantity) VALUES('" + client.username + "','" + book.isbn + "'," + (int)numericUpDown1.Value + ");");

            myCommand.Connection = myConnection;
            SqlDataReader myReader = myCommand.ExecuteReader();

            myConnection.Close();

        }

      
        public Book book { get; set; }
        public Client client { get; set; }  

    }
}

