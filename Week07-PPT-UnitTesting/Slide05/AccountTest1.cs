using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Slide05
{
    [TestClass]
    public class AccountTest1
    {
        [TestMethod]
        public void Test_Withdraw_WithoutException()
        {
            // ARRANGE
            double beginningBalance = 10.99;
            double withdrawAmount = 5.25;
            double expectedBalance = beginningBalance - withdrawAmount;

            Account account = new Account("Narendra", beginningBalance);

            // ACT
            account.Withdraw(withdrawAmount);

            // ASSERT
            Assert.AreEqual(expectedBalance, account.Balance, 0.0001, "Failure message");
        }
    }
}
