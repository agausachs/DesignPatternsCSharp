namespace DesignPatterns.SolidPrinciples.OpenClosed
{
    public class GoodCorporateAccount : IAccount
    {
        public decimal Balance { get; set; }

        public decimal CalcInterest()
        {
            decimal Interest = (Balance * 3) / 100;

            return Interest;
        }
    }
}
