using AtmModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtmLogic
{
    public class ProcessWithdrawal
    {
        public List<Denomination> WithdrawMoney(double requireAmount)
        {
            double amountRemaining = requireAmount;
            var denominationsWithdrawn = new List<Denomination>();

            IDenominationLogic logic = new DenominationLogic();

            var denominations = logic.GetDenominationValue().OrderByDescending(o => o.DenominationValue);

            denominationsWithdrawn =  denominations.Select(d => {
               var den = new ProcessDenomination(d.DenominationValue, amountRemaining).Calculate();
               amountRemaining = amountRemaining - (den.DenominationValue * den.Quantity);
               return den;
           }).Where(r => r.Quantity > 0).ToList();

            return denominationsWithdrawn;
        }
    }
}
