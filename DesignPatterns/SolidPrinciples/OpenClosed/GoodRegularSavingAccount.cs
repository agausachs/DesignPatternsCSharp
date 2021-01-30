namespace DesignPatterns.SolidPrinciples.OpenClosed
{
    public class GoodRegularSavingAccount : IAccount
    {
        public decimal Balance { get; set; } = 0;

        public decimal CalcInterest()
        {
            decimal Interest = (Balance * 4) / 100;

            if (Balance < 1000) Interest -= (Balance * 2) / 100;

            if (Balance < 50000) Interest += (Balance * 4) / 100;

            return Interest;
        }
    }
}
