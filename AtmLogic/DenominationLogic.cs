using AtmModel;
using AtmRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtmLogic
{
    public class DenominationLogic : IDenominationLogic
    {
        public double GetDenominationTotal()
        {
            var total = DenominationRepository.InitialState.Select(x => (x.Quantity * x.Value)).Sum();

            return total;
        }

        public List<Denomination> GetDenominationValue()
        {
            var denomination = DenominationRepository.CurrentState;

            return denomination;
        }

        public List<Denomination> UpdateDenomination(double denomination, int quantity)
        {
            var currentState = DenominationRepository.CurrentState;

           var change = currentState.Where(x => x.DenominationValue == denomination).ToList();
            DenominationRepository.CurrentState.Where(x
                => x.DenominationValue == denomination).Select(z
                =>
                { z.Quantity += quantity; return z; }).ToList();
            // DenominationRepository.CurrentState;


            return currentState;
        }
    }
}
