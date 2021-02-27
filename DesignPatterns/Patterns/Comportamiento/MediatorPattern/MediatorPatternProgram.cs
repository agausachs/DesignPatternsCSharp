using System;
namespace DesignPatterns.Patterns.Comportamiento.MediatorPattern
{
    public static class MediatorPatternProgram
    {
        public static void Run()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine(" MEDIATOR PATTERN ");
            Console.WriteLine("-------------------------");

            // El código cliente.
            Component1 component1 = new Component1();
            Component2 component2 = new Component2();
            _ = new ConcreteMediator(component1, component2);

            Console.WriteLine("El Cliente dispara la operación A.");
            component1.DoA();

            Console.WriteLine("\n");

            Console.WriteLine("El Cliente dispara la operación D.");
            component2.DoD();

            Console.WriteLine("\n");
        }
    }
}
