using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Order
    {
        private static int _no;
        public int No { get; }
        public int ProductCount { get; set; }
        public double TotalAmount { get; set; }
        public DateTime CreatedAt { get; set; }

        static Order()
        {
            _no = 0;
        }
        public Order()
        {
            _no++;
            No = _no;
           
        }
        public void ShowInfo()
        {
            Console.WriteLine($"No:{No} -> MehsulSayi:{ProductCount} -> UmumiQiymet:{TotalAmount} -> SifarisTarix:{CreatedAt}");
        }
    }
}
