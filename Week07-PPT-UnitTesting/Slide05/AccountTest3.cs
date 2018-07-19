using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Slide05
{
    [TestClass]
    public class AccountTest3
    {
        [TestMethod]
        public void Withdraw_WhenAmountIsMoreThanLimit_ShouldThrowArgumentOutOfRange()
        {
            // ARRANGE
            double beginningBalance = 500.00;
            double withrawAmount = 300;

            Account account = new Account("Narendra", beginningBalance);

            try
            {
                // ACT
                account.Withdraw(withrawAmount);
            }
            catch(ArgumentOutOfRangeException e)
            {
                // ASSERT
                StringAssert.Contains(e.Message, Account.WithdrawAmountMoreThanLimitMessage);
            }
        }
    }
}
