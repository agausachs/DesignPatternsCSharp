using System;
namespace DesignPatterns.Patterns.Comportamiento.VisitorPattern
{
    public class ConcreteComponentB : IComponent
    {
        // Lo mismo aquí: VisitConcreteComponentB => ConcreteComponentB
        public void Accept(IVisitor visitor)
        {
            visitor.VisitConcreteComponentB(this);
        }

        public string SpecialMethodOfConcreteComponentB()
        {
            return "B";
        }
    }
}
