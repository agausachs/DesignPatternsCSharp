using System;
namespace DesignPatterns.Patterns.Estructurales.DecoratorPattern
{
    // Los decoradores concretos llaman al objeto envuelto y alteran su resultado de alguna
    // manera.
    public class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(Component comp) : base(comp)
        {
        }

        // Los decoradores pueden llamar a la implementación principal de la operación, en su lugar
        // de llamar directamente al objeto envuelto. Este enfoque simplifica la
        // extensión de las clases de decoradores.
        public override string Operation()
        {
            return $"ConcreteDecoratorA({base.Operation()})";
        }
    }
}
