using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class Customer
    {
        public int CustId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int EmpID { get; set; }
    }
}
