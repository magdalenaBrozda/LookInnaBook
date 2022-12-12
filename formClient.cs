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
    public partial class formClient : Form
    {

        public formClient(Client currentClient)
        {
            client = currentClient;
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
           loadBooksToList();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem selectedItem = listView1.SelectedItems[0];
            formBookDetails selectedBook = new formBookDetails((Book)selectedItem.Tag, client);
            selectedBook.ShowDialog();
        }

        private void formClient_Load(object sender, EventArgs e)
        {
            loadBooksToList();
        }


        private void loadBooksToList()
        {
            listView1.Clear();

            SqlConnection myConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LookInnaBook;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            myConnection.Open();
            string search = textBoxSearch.Text;


            SqlCommand myCommand = new SqlCommand("SELECT * FROM storeinventory");
            myCommand.Connection = myConnection;

            SqlDataReader myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {


                IDataRecord myIDataRecord = ((IDataRecord)myReader);


                Book myBook = new Book();
                myBook.isbn = myIDataRecord[0].ToString();
                myBook.title = myIDataRecord[1].ToString();
                myBook.genre = myIDataRecord[2].ToString();
                myBook.numpages = (int)myIDataRecord[3];
                myBook.price = (float)(decimal)myIDataRecord[4];
                myBook.author = myIDataRecord[5].ToString();
                myBook.publisher = myIDataRecord[6].ToString();
                myBook.salespercentage = (float)(decimal)myIDataRecord[7];
                myBook.copiesinstore = (int)myIDataRecord[8];
                myBook.copiessold = (int)myIDataRecord[9];




                if (search.Length == 0 ||
                    myBook.title == search ||
                    myBook.genre == search ||
                    myBook.author == search)
                {
                    ListViewItem lvItem = listView1.Items.Add("Title: " + myBook.title + " | Genre: " + myBook.genre + " | Author: " + myBook.author);

                    lvItem.Tag = myBook;
                    listView1.Show();
                }

            }

            myConnection.Close();
        }

        Client client;

        

        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            formCheckOut checkOut = new formCheckOut(client);
            checkOut.ShowDialog();

        }
    }
}
