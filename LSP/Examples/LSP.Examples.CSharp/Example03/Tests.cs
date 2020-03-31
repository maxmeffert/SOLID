using NUnit.Framework;
using System.Collections;

namespace Example03
{
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