using System;
using System.Globalization;
using Store.Entities;
using Store.Entities.Enums;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data: ");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client c = new Client(name, email, birthDate);
            Console.WriteLine("Enter order data:");

            Console.Write("Status: ");
            string aux = Console.ReadLine();
            OrderStatus os = Enum.Parse<OrderStatus>(aux);

            Order order = new Order(DateTime.Now, os, c);
            Console.Write("How many items to this order? ");
            int quant = int.Parse(Console.ReadLine());

            for(int i = 1; i <= quant; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");

                Console.Write("Product name: ");
                string n = Console.ReadLine();

                Console.Write("Product price: ");
                double p = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Quantity: ");
                int q = int.Parse(Console.ReadLine());

                Product prod = new Product(n, p);
                OrderItem oi = new OrderItem(q, p, prod);
                order.AddItem(oi);
            }
            Console.WriteLine(order);

        }
    }
}
