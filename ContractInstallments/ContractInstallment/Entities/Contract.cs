using System;
using System.Collections.Generic;


namespace ContractInstallment.Entities
{
    class Contract
    {
        public int Number { get; private set; }
        public DateTime Date{ get; private set; }
        public double TotalValue { get; set; }
        public List<Installment> Installments { get; set; }

        public Contract(int number, DateTime date, double totalValue)
        {
            this.Number = number;
            this.Date = date;
            this.TotalValue = totalValue;
            this.Installments = new List<Installment>();
        }

        public void AddInstallment(Installment installment)
        {
            this.Installments.Add(installment);
        }
    }
}
