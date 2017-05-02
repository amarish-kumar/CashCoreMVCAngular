
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using AtmLogic;
using AtmModel;

namespace AtmService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AtmService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AtmService.svc or AtmService.svc.cs at the Solution Explorer and start debugging.
    public class AtmService : IAtmService
    {
        public List<Denomination> ProcessWithdrawal(double requireAmount)
        {
            var defaultProcess = new ProcessWithdrawal();
            var den = defaultProcess.WithdrawMoney(requireAmount);

            return den;
        }

        public List<Denomination> GetDenominationValue()
        {
            IDenominationLogic logic = new DenominationLogic();
            var denominations = logic.GetDenominationValue();

            return denominations;
        }
    }
}
