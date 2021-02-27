using System;
namespace DesignPatterns.Patterns.Comportamiento.MediatorPattern
{
    public class Component2 : BaseComponent
    {
        public void DoC()
        {
            Console.WriteLine("Component 2 hace C.");

            _mediator.Notify(this, "C");
        }

        public void DoD()
        {
            Console.WriteLine("Component 2 hace D.");

            _mediator.Notify(this, "D");
        }
    }
}
