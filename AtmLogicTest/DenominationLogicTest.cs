using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AtmLogic;
using System.Linq;

namespace AtmLogicTest
{
    [TestClass]
    public class DenominationLogicTest
    {
        [TestMethod]
        public void GetDenominationTotalTest()
        {
            IDenominationLogic logic = new DenominationLogic();

            var total = logic.GetDenominationTotal();

            Assert.AreEqual(4638, total);
        }

        [TestMethod]
        public void GetDenominationValueTest()
        {
            IDenominationLogic logic = new DenominationLogic();
            var denominations = logic.GetDenominationValue();
            Assert.AreEqual(12, denominations.Count);
        }

        [TestMethod]
        public void WithdrawMoneyMaxTest()
        {
            var defauklProcess = new ProcessWithdrawal();
            var den = defauklProcess.WithdrawMoney(4638d);

            Assert.AreEqual(12, den.Count);

            Assert.AreEqual(4638d, den.Sum(x => x.Quantity * x.Value));

            IDenominationLogic logic = new DenominationLogic();
            var denominations = logic.GetDenominationValue();
            // no money left
            Assert.AreEqual(0, denominations.Sum(x => x.Quantity * x.Value));
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void WithdrawMoneyOverTest()
        {
            var defauklProcess = new ProcessWithdrawal();
            var den = defauklProcess.WithdrawMoney(4639d);

            Assert.AreEqual(0, den.Count);

            Assert.AreEqual(0d, den.Sum(x => x.Quantity * x.Value));
        }

        [TestMethod]
        public void WithdrawZeroMoneyTest()
        {
            var defauklProcess = new ProcessWithdrawal();
            var den = defauklProcess.WithdrawMoney(0d);

            Assert.AreEqual(0, den.Count);

            Assert.AreEqual(0, den.Sum(x => x.Quantity * x.Value));
        }
    }
}
