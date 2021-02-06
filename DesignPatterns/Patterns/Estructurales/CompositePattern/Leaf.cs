using System;
namespace DesignPatterns.Patterns.Estructurales.CompositePattern
{
    public class Leaf : Component
    {
        public override string Operation()
        {
            return "Hoja";
        }

        public override bool IsComposite()
        {
            return false;
        }
    }
}
