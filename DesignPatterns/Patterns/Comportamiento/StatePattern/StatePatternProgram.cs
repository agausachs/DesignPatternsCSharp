using System;
namespace DesignPatterns.Patterns.Comportamiento.StatePattern
{
    public static class StatePatternProgram
    {
        public static void Run()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine(" STATE PATTERN ");
            Console.WriteLine("-------------------------");

            Console.WriteLine("\n");

            // El código cliente.
            Context context = new Context(new ConcreteStateA());
            context.Request1();
            context.Request2();

            Console.WriteLine("\n");
        }
    }
}
