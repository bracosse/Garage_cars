using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class SparePart
    {
        public int PartID { get; set; }
        public string PartName { get; set; }
        public string PartProvider { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
}
