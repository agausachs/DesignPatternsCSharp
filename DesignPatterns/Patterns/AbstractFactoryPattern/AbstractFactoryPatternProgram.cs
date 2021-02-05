using System;
namespace DesignPatterns.Patterns.AbstractFactoryPattern
{
    // El código de cliente funciona con fábricas y productos solo a través de
    // tipos abstractos: AbstractFactory y AbstractProduct. Esto le permite pasar cualquier
    // fábrica o subclase de producto al código del cliente sin romperlo.
    public static class AbstractFactoryPatternProgram
    {
        public static void Run()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine(" ABSTRACT FACTORY PATTERN ");
            Console.WriteLine("-------------------------");

            // El código cliente puede trabajar con cualquier clase factory concreta.
            Console.WriteLine("Cliente: Testeando el código cliente con el primer tipo de factory...");
            ClientMethod(new ConcreteFactory1());
            Console.WriteLine();

            Console.WriteLine("Cliente: Testeando el mismo tipo de código cliente con el segundo tipo de factory...");
            ClientMethod(new ConcreteFactory2());
        }

        private static void ClientMethod(IAbstractFactory factory)
        {
            IAbstractProductA productA = factory.CreateProductA();
            IAbstractProductB productB = factory.CreateProductB();

            Console.WriteLine(productB.UsefulFunctionB());
            Console.WriteLine(productB.AnorherUsefulFunctionB(productA));
        }
    }
}
