using System;
using System.Globalization;
using Bank.Entities;
using Bank.Entities.Exceptions;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");

                Console.Write("Number: ");
                int n = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string h = Console.ReadLine();

                Console.Write("Initial balance: ");
                double ib = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Withdraw limit: ");
                double wl = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account ac = new Account(n, h, ib, wl);

                Console.Write("\nEnter amount for withdraw: ");
                double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                ac.Withdraw(a);
                Console.WriteLine("New balance: " + ac.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch(DomainException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error in format: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }


        }
    }
}
