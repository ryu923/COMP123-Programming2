using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Slide05
{
    [TestClass]
    public class AccountTest2
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Withdraw_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange()
        {
            // ARRANGE
            double beginningBalance = 10.99;
            double withdrawAmount = 200;

            Account account = new Account("Narendra", beginningBalance);

            // ACT
            account.Withdraw(withdrawAmount);

            // ASSERT is handle by Exception
        }
    }
}
