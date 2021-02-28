using System;
namespace DesignPatterns.Patterns.Comportamiento.StatePattern
{
    // Los estado concretos implementan varios comportamientos, asociados al estado del contexto.
    public class ConcreteStateA : State
    {
        public override void Handle1()
        {
            Console.WriteLine("ConcreteStateA maneja la request1.");
            Console.WriteLine("ConcreteStateA quiere cambiar el estado del contexto.");
            _context.TransitionTo(new ConcreteStateB());
        }

        public override void Handle2()
        {
            Console.WriteLine("ConcreteStateA maneja la request2.");
        }
    }
}
