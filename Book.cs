using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LookInnaBook
{
    public class Book
    {
        public String title { get; set; }
        public String isbn { get; set; }
        public String genre { get; set; }
        public int numpages { get; set; }
        public float price { get; set; }
        public String author { get; set; }
        public String publisher { get; set; }
        public float salespercentage { get; set; }
        public int copiesinstore { get; set; }
        public int copiessold { get; set; }


    }
}
