namespace Example03
{
    public class Account 
    {
        public double Balance { get; protected set; }
        public virtual void Withdraw(double withdrawal)
        {
            Balance -= withdrawal;
        }
    }
}