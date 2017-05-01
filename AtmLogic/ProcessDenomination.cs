using System;
using System.Collections.Generic;
using System.Text;
using AtmModel;
using System.Linq;

namespace AtmLogic
{
    public class ProcessDenomination : BaseValidation, IWithDraw
    {
        /// <summary>
        /// the denomination to process
        /// </summary>
        public double DenominationToProcess { get; set; }

        public double RequireAmount { get; set; }

        /// <summary>
        /// returns the withdrawn moneies 
        /// </summary>
        /// <param name="denominationToProcess">the face value</param>
        /// <param name="requireAmount">the amount to get</param>
        public ProcessDenomination(double denominationToProcess , double requireAmount)
        {
            DenominationToProcess = denominationToProcess;
            RequireAmount = requireAmount;
        }


        public Denomination Calculate()
        {
            base.Validate(RequireAmount);

            var denominationWithdrawn = new Denomination() { DenominationValue = DenominationToProcess, Value = DenominationToProcess };

            IDenominationLogic logic = new DenominationLogic();

            var denominations = logic.GetDenominationValue();
            var denominationBeingProcess = denominations.Where(x => x.DenominationValue == DenominationToProcess).SingleOrDefault();
            var quantity = (int)(RequireAmount / DenominationToProcess);
            // make sure we have enough notes
            if (quantity > denominationBeingProcess.Quantity)
            {
                quantity = denominationBeingProcess.Quantity;
            }
            if (quantity > 0)
            {
                // dispense the denomination
                denominationWithdrawn.Quantity = quantity;
                logic.UpdateDenomination(DenominationToProcess, -quantity);
            }

            return denominationWithdrawn;
        }
    }
}
