using NUnit.Framework;
using System;
using System.Collections;

namespace Tests
{    
    public class Account 
    {
        public double Balance { get; protected set; }
        public virtual void Withdraw(double withdrawal)
        {
            Balance -= withdrawal;
        }
    }

    public class ProtectedAccount : Account
    {
        // ProtectedAccounts strenghens the precondition for Account.Widthrawl!
        public override void Withdraw(double withdrawal)
        {
            if (Balance - withdrawal < 0)
            {
                throw new InvalidOperationException();
            }
            base.Withdraw(withdrawal);
        }
    }


    public class Tests
    {
        public static IEnumerable TestCases()
        {
            yield return new Account();
            yield return new ProtectedAccount();
        }
        [Test]
        [TestCaseSource(nameof(TestCases))]
        public void Test(Account account)
        {
            var withdrawal = 200;
            var oldBalance = account.Balance;
            var newBalance = oldBalance - withdrawal;

            account.Withdraw(withdrawal);

            Assert.AreEqual(newBalance, account.Balance);
        }
    }
}