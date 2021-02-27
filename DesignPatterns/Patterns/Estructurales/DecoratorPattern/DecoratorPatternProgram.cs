using System;
namespace DesignPatterns.Patterns.Estructurales.DecoratorPattern
{
    public static class DecoratorPatternProgram
    {
        public static void Run()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine(" DECORATOR PATTERN ");
            Console.WriteLine("-------------------------");

            Client client = new Client();

            ConcreteComponent simple = new ConcreteComponent();
            Console.WriteLine("Client: Tengo un componente simple:");
            client.ClientCode(simple);
            Console.WriteLine();

            Console.WriteLine("\n");

            // ... así como decorados.
            //
            // Observa cómo los decoradores pueden envolver no solo componentes simples sino también
            // otros decoradores.

            ConcreteDecoratorA decorator1 = new ConcreteDecoratorA(simple);
            ConcreteDecoratorB decorator2 = new ConcreteDecoratorB(simple);
            Console.WriteLine("Client: Ahora tengo un componente decorado:");
            client.ClientCode(decorator2);

            Console.WriteLine("\n");
        }
    }
}
