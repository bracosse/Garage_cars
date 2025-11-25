using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public int CustID { get; set; }
        public string CarName { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
        public string Issue { get; set; }
        public string Fixed { get; set; }
    }
    public class YesNo
    {
        public string Name { get; set; }
        //public string Value { get; set; }
    }
}
