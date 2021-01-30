namespace DesignPatterns.SolidPrinciples.OpenClosed
{
    public class GoodSalarySavingAccount : IAccount
    {
        public decimal Balance { get; set; } = 0;

        public decimal CalcInterest()
        {
            decimal Interest = (Balance * 5) / 100;

            return Interest;
        }
    }
}
