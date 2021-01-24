using System;
namespace DesignPatterns.Patterns.FactoryMethodPattern
{
    public static class FactoryMethodPatternProgram
    {
        public static void Run()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine(" FACTORY METHOD PATTERN ");
            Console.WriteLine("-------------------------");

            Console.WriteLine("App: Lanzada con el ConcreteCreator1.");
            ClientCode(new ConcreteCreator1());

            Console.WriteLine("\n");

            Console.WriteLine("App: Lanzada con el ConcreteCreator2.");
            ClientCode(new ConcreteCreator2());
        }

        // El código cliente funciona con una instancia de un Creator concreto, aunque
        // a través de su interface base. En tanto el cliente continue trabajando
        // con el Creator via su interface base, se le puede pasar cualquier subclase
        // de Creator.
        public static void ClientCode(Creator creator)
        {
            // ...

            Console.Write("Cliente: No soy consciente de la clase Creator," +
                "pero aún así funciono.\n" + creator.SomeOperation());
            // ...
        }
    }
}
