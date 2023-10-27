using ClassLibrary.Models;

namespace ShopConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();

            Order order1 = new Order
            {
                ProductCount = 5,
                TotalAmount = 100,
                CreatedAt = new DateTime(2023, 10, 25)
            };

            Order order2 = new Order
            {
                ProductCount = 3,
                TotalAmount = 75,
                CreatedAt = new DateTime(2023, 7, 26)
            };

            Order order3 = new Order
            {
                ProductCount = 2,
                TotalAmount = 120,
                CreatedAt = new DateTime(2023, 8, 26)
            };

            shop.AddOrder(order1);
            shop.AddOrder(order2);
            shop.AddOrder(order3);

            foreach (Order order in shop.Orders)
            {
                order.ShowInfo();
            }

            double getAvgOfOrders = shop.GetOrdersAvg();
            Console.WriteLine($"Average of the all orders:{getAvgOfOrders}");

            DateTime dateTime = new DateTime(2023, 10, 20);
            double getAvgOfOrdersByDate = shop.GetOrdersAvg(dateTime);
            Console.WriteLine($"Average of the all orders according to the dateTime:{getAvgOfOrdersByDate}");

            shop.RemoveOrderByNo(1);


            List<Order> filteredOrders = shop.FilterOrderByPrice(100, 400);
            foreach (Order order in filteredOrders)
            {
                order.ShowInfo();
            }

        }
    }
}