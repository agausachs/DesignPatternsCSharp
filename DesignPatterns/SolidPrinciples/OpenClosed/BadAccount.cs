using System;
namespace DesignPatterns.SolidPrinciples.OpenClosed
{
    public class BadAccount
    {
        public decimal Interest { get; set; }
        public decimal Balance { get; set; }

        // miembros y declaración de funciones
        public decimal CalcInterest(string accType)
        {
            if (accType == "Regular") // ahorros
            {
                Interest = (Balance * 4) / 100;

                if (Balance < 1000) Interest -= (Balance * 2) / 100;
                if (Balance < 50000) Interest += (Balance * 4) / 100;
            }
            else if (accType == "Salary") // ahorros de salario
            {
                Interest = (Balance * 5) / 100;
            }
            else if (accType == "Corporate") // Corporativo
            {
                Interest = (Balance * 3) / 100;
            }

            return Interest;
        }

    }
}
