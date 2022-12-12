using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LookInnaBook
{
    public class Client
    {
        public Client(String valName, String valUsername, String valPassword, String valPhonenumber, String valAddress, String valCreditcardnumber)
        {
            name = valName;     
            username = valUsername; 
            password = valPassword; 
            phonenumber = valPhonenumber;   
            address = valAddress;   
            creditCardNumber = valCreditcardnumber; 

        }






        public String name { get; set; }
        public String username { get; set; }
        public String password { get; set; }
        public String phonenumber { get; set; }
        public String address { get; set; }
        public String creditCardNumber { get; set; }
        








    }

}
