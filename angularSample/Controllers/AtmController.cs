using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AtmService;

namespace AtmUI.Controllers
{
    [Route("api/[controller]")]
    public class AtmController : Controller
    {

        [HttpGet("[action]")]
        public async Task<IEnumerable<Denomination>> ProcessWithdrawalAsync(double requireAmount)
        {

            var atm = await new AtmServiceClient().ProcessWithdrawalAsync(requireAmount);

            return atm;
        }

        [HttpGet("[action]")]
        public async Task<IEnumerable<Denomination>> GetDenominationValueAsync()
        {
            var atm = await new AtmServiceClient().GetDenominationValueAsync();

            return atm;
        }
    }
}
