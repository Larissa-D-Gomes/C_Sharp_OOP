using System;
using System.Globalization;

namespace Property
{
    class Program
    {
        static void Main(string[] args)
        {
            double aux;
            Conta c;
            Console.Write("Entre o número da conta: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            string resp = Console.ReadLine();
            
            if(resp.ToLower().Equals("s"))
            {
                Console.Write("Entre o valor de depósito inicial: ");
                aux = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new Conta(nome, num, aux);
            } 
            else
            {
               c = new Conta(nome, num);
            }

            Console.WriteLine("\nDados da conta:\n" + c + "\n");

            Console.Write("Entre um valor para depósito: ");
            aux = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.depositar(aux);
            Console.WriteLine("\nDados da conta atualizados:\n" + c + "\n");

            Console.Write("Entre um valor para saque: ");
            aux = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.sacar(aux);
            Console.WriteLine("\nDados da conta atualizados:\n" + c + "\n");
        }
    }
}
