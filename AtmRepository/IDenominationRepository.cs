using System.Collections.Generic;
using AtmModel;

namespace AtmRepository
{
    public interface IDenominationRepository
    {
        List<Denomination> GetAvailableDenomination();
    }
}