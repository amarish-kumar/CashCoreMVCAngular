using AtmModel;
using System.Collections.Generic;

namespace AtmLogic
{
    public interface IDenominationLogic
    {
        double GetDenominationTotal();
        List<Denomination> GetDenominationValue();
        List<Denomination> UpdateDenomination(double denomination, int quantity);
    }
}