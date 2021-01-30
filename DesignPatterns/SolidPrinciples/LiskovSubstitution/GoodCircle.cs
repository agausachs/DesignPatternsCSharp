using System;
namespace DesignPatterns.SolidPrinciples.LiskovSubstitution
{
    public class GoodCircle: GoodTriangle
    {
        public override string GetShape()
        {
            return "Circulo";
        }
    }
}
