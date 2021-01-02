﻿using System;
using System.Globalization;
using System.Collections.Generic;
using ProductTag.Entities;


namespace ProductTag
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char c = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if ( c == 'c')
                {
                    list.Add(new Product(name, price));
                }
                else if( c == 'u')
                {
                    Console.Write("Manufacture date(DD / MM / YYYY): ");
                    DateTime time = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, time));
                }
                else
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customsFee));

                }
            }

            Console.WriteLine("\nPRICE TAGS:");

            foreach (Product p in list)
            {
                Console.WriteLine(p.PriceTag());
            }
        }
    }
}
