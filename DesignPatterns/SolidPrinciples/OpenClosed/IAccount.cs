namespace DesignPatterns.SolidPrinciples.OpenClosed
{
    public interface IAccount
    {
        decimal Balance { get; set; }

        decimal CalcInterest();
    }
}