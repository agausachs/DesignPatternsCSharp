using System;
namespace DesignPatterns.Patterns.Comportamiento.TemplateMethodPattern
{
    public static class TemplateMethodPatternProgram
    {
        public static void Run()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine(" TEMPLATE METHOD PATTERN ");
            Console.WriteLine("-------------------------");

            Console.WriteLine("\n");

            Console.WriteLine("El mismo código cliente puede funcionar con diferentes subclases:");

            Client.ClientCode(new ConcreteClass1());

            Console.WriteLine("\n");

            Console.WriteLine("Insisto que el mismo código cliente puede funcionar con diferentes subclases:");

            Client.ClientCode(new ConcreteClass2());

            Console.WriteLine("\n");
        }
    }
}
