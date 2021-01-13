using System;
using System.Globalization;

namespace ContractInstallment.Entities
{
    class Installment
    {
        public DateTime DueDate { get; private set; }
        public double Amount { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            this.DueDate = dueDate;
            this.Amount = amount;
        }

        public override string ToString()
        {
            return this.DueDate.ToString("dd/MM/yyyy") + " - "
                + this.Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
