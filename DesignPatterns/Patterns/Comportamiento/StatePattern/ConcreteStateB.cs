using System;

namespace DesignPatterns.Patterns.Comportamiento.StatePattern
{
    public class ConcreteStateB : State
    {
        public override void Handle1()
        {
            Console.WriteLine("ConcreteStateB maneja la request1.");
        }

        public override void Handle2()
        {
            Console.WriteLine("ConcreteStateB maneja la request2.");
            Console.WriteLine("ConcreteStateB quiere cambiar el estado del contexto.");
            _context.TransitionTo(new ConcreteStateA());
        }
    }
}