using System;
using System.Globalization;
using Bank.Entities.Exceptions;

namespace Bank.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; private set; }

        // Constructor
        // @param int number, string holder, double balance, double withdrawLimit
        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            this.Number = number;
            this.Holder = holder;
            this.Balance = balance;
            this.WithdrawLimit = withdrawLimit;
        }

        // Methods

        /* Deposit method
         * @param double amount
         */
        public void Deposit(double amount)
        {
            if (amount <= 0.0)
                throw new DomainException("Deposit error: Invalid deposit amount");

            this.Balance += amount;
        }

        /* Withdraw method
         * @param double amount
         */
        public void Withdraw(double amount)
        {
            if (amount > this.WithdrawLimit)
                throw new DomainException("Withdraw error: The amount exceeds withdraw limit");

            if (amount > this.Balance)
                throw new DomainException("Withdraw error: Not enough balance");


            this.Balance -= amount;
        }

        public override string ToString()
        {
            return   "Number: " + this.Number
                   + "Holder: " + this.Holder
                   + "Balance: " + this.Balance.ToString("F2", CultureInfo.InvariantCulture)
                   + "Withdraw limit: "
                   + this.WithdrawLimit.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
