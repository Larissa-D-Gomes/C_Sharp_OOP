using System;
using System.Collections.Generic;
using ContractInstallment.Entities;

namespace ContractInstallment.Services
{
    class ContractService
    {
        private IOnlinePaymentService _iOnlinePaymentService;

        public ContractService(IOnlinePaymentService ionlinePaymentService)
        {
            this._iOnlinePaymentService = ionlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;

            for(int i = 1; i <= months; i++)
            {
                DateTime aux = contract.Date.AddMonths(i);
                double total = basicQuota + this._iOnlinePaymentService.Interest(basicQuota, i); 
                total += this._iOnlinePaymentService.PaymentFee(total);
                contract.AddInstallment(new Installment(aux, total));
                
            }
        }
    }
}
