using System;
using System.Collections.Generic;
using System.Text;

namespace AtmLogic
{
    public class BaseValidation 
    {
        public void Validate(double requireAmount)
        {

            if (requireAmount < 0)
            {
                throw new ArgumentException("amount less than zero", "requireAmount");
            }
            IDenominationLogic logic = new DenominationLogic();
            var total = logic.GetDenominationTotal();
            if (requireAmount > total)
            {
                throw new ArgumentException("you don't have enough money to fulfill your request", "requireAmount");
            }
        }
    }
}
