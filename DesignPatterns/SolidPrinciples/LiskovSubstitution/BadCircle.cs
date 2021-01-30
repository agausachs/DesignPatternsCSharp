using System;
namespace DesignPatterns.SolidPrinciples.LiskovSubstitution
{
    public class BadCircle: BadTriangle
    {
        public override string GetShape()
        {
            return "Circulo";
        }
    }
}
