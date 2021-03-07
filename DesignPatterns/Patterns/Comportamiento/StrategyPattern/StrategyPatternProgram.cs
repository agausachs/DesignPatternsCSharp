using System;
namespace DesignPatterns.Patterns.Comportamiento.StrategyPattern
{
    public static class StrategyPatternProgram
    {
        public static void Run()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine(" STRATEGY PATTERN ");
            Console.WriteLine("-------------------------");

            Console.WriteLine("\n");

            // El código del cliente elige una estrategia concreta y la pasa al
            // contexto. El cliente debe conocer las diferencias entre
            // estrategias para tomar la decisión correcta.
            var context = new Context();

            Console.WriteLine("Cliente: Strategy está en modo orden normal.");

            context.SetStrategy(new ConcreteStrategyA());

            context.DoSomeBusinessLogic();

            Console.WriteLine();

            Console.WriteLine("Cliente: Strategy está en modo orden inverso.");

            context.SetStrategy(new ConcreteStrategyB());

            context.DoSomeBusinessLogic();

            Console.WriteLine("\n");
        }
    }
}
