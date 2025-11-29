using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    internal class Archive
    {
        public int ArchiveID { get; set; }
        public int EmployeeID { get; set; }
        public int CustomerID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public int CarID { get; set; }
        public string Issue { get; set; }
        public string PartName { get; set; }
        public string PartProvider { get; set; }
        public int Quantity { get; set; }
        public int ServicePrice { get; set; }
        public int FinalPrice { get; set; }
    }
}
