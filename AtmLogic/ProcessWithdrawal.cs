using AtmModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtmLogic
{
    public class ProcessWithdrawal
    {
        public List<Denomination> WithdrawMoney(double requireAmount, double? startWithDenominationValue = null)
        {
            double amountRemaining = requireAmount;
            var denominationsWithdrawn = new List<Denomination>();

            IDenominationLogic logic = new DenominationLogic();

            var denominations = logic.GetDenominationValue().OrderByDescending(o => o.DenominationValue);

            if (startWithDenominationValue.HasValue)
            {
                var preprocessDen = new ProcessDenomination(startWithDenominationValue.Value, amountRemaining).Calculate();
                denominationsWithdrawn.Add(preprocessDen);
            }

            denominationsWithdrawn = denominations.Select(d =>
            {
                var den = new ProcessDenomination(d.DenominationValue, amountRemaining).Calculate();
                amountRemaining = amountRemaining - (den.DenominationValue * den.Quantity);
                return den;
            }).Where(r => r.Quantity > 0).ToList();

            return denominationsWithdrawn;
        }
    }
}
