using System;
namespace DesignPatterns.SolidPrinciples.LiskovSubstitution
{
    public class GoodTriangle: GoodShape
    {
        public override string GetShape()
        {
            return "Triangulo";
        }
    }
}
