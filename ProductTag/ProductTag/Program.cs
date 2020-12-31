using System;
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

                Console.Write("Price: ");

                if ( c == 'c')
                {

                    list.Add(new Product());
                }
            }
        }
    }
}
