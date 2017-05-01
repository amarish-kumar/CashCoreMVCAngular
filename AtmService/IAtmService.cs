using AtmModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AtmService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAtmService" in both code and config file together.
    [ServiceContract]
    public interface IAtmService
    {
        [OperationContract]
        List<Denomination> ProcessWithdrawal(double requireAmount);

        [OperationContract]
        List<Denomination> GetDenominationValue();
    }
}
