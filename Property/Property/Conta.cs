using System;
using System.Globalization;


namespace Property
{
    class Conta
    {
        public double Saldo { get; private set; }
        private string _nome;
        public int NumeroCont { get; private set; }

        //Construtores

        /* Construtor atributos obrigatórios
         * @param string nome, int numeroCont
         */
        public Conta(string nome, int numeroCont)
        {
            this._nome = nome;
            this.NumeroCont = numeroCont;
        }

        /* Construtor atributos obrigatorios e saldo inicial 
         * @param string nome, int numeroCont, double saldo
         */
        public Conta(string nome, int numeroCont, double saldo) : this(nome, numeroCont)
        {
            this.Saldo = saldo;
        }

        // Propriedades 
        public string Nome
        {
            get
            {
                return this._nome;
            }
            set
            {
                if (value != null && value.Length > 1)
                    this._nome = value;
            }
        }


        // Métodos

        /*Método para sacar*/
        public void sacar(double valor)
        {
            if (valor > 0.0)
                this.Saldo = Saldo - valor - 5;
        }

        /*Método para depositar*/
        public void depositar(double valor)
        {
            if (valor > 0.0)
                this.Saldo += valor;
        }
        public override string ToString()
        {
            return "Conta: " + this.NumeroCont
                   + ", Titular: " + this.Nome + ", Saldo: $ " 
                   + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
