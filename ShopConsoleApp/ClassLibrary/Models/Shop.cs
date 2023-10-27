using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Shop
    {
        public List<Order> Orders { get; } = new List<Order>();
        public void AddOrder(Order order)
        {
            if (order != null)
            {
                Orders.Add(order);
            }
            else
            {
                Console.WriteLine("Order obyekti null ola bilmez!!!");
            }
        }
        public double GetOrdersAvg()
        {
            foreach (Order order in Orders)
            {
                if (order.ProductCount == 0)
                {
                    return 0;
                }
            }
            double totalAmount = Orders.Sum(order => order.TotalAmount);
            double totalCount = Orders.Sum(order => order.ProductCount);
            return totalAmount / totalCount;
        }
        public double GetOrdersAvg(DateTime date)
        {
            List<Order> filteredListByDate = Orders.FindAll(order => order.CreatedAt >= date);
            double totalAmountByDate = filteredListByDate.Sum(order => order.TotalAmount);
            double totalCountByDate = filteredListByDate.Sum(order => order.ProductCount);

            if (filteredListByDate.Count == 0)
            {
                return 0;
            }

            return totalAmountByDate / totalCountByDate;


        }
        public void RemoveOrderByNo(int? orderNo)
        {
            if (orderNo != null)
            {
                Orders.RemoveAll(order => order.No == orderNo);
            }
        }
        public List<Order> FilterOrderByPrice(double minPrice, double maxPrice)
        {
            return Orders.FindAll(order => order.TotalAmount >= minPrice && order.TotalAmount <= maxPrice);
        }
    }
}
