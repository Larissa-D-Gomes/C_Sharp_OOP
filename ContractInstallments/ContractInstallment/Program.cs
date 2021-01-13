using System;
using System.Globalization;
using ContractInstallment.Entities;
using ContractInstallment.Services;

namespace ContractInstallments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter number of installments: ");
            int installments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, value);
            PaypalService paypal = new PaypalService();
            ContractService cs = new ContractService(paypal);
            cs.ProcessContract(contract, installments);

            foreach (Installment i in contract.Installments)
                Console.WriteLine(i);
        }
    }
}
