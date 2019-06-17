using System;

namespace Example03
{
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
}