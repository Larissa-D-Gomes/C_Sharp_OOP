using System;
using System.Collections.Generic;
using System.Text;

namespace Moedas
{
    class ConversorDeMoeda
    {
        private static double IOF = 6.0;
        
        public static double Total(double cotacao, double quantidade)
        {
            double p = quantidade * cotacao;
            return p + p * IOF / 100;
        }
    }
}
