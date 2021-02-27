using System;
namespace DesignPatterns.Patterns.Comportamiento.MediatorPattern
{
    public class Component1 : BaseComponent
    {
        public void DoA()
        {
            Console.WriteLine("Componente 1 hace A.");

            _mediator.Notify(this, "A");
        }

        public void DoB()
        {
            Console.WriteLine("Componente 2 hace B.");

            _mediator.Notify(this, "B");
        }
    }
}
