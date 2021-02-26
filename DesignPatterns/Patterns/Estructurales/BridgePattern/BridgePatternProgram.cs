using System;
namespace DesignPatterns.Patterns.Estructurales.BridgePattern
{
    public static class BridgePatternProgram
    {
        public static void Run()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine(" BRIDGE PATTERN ");
            Console.WriteLine("-------------------------");

            Client client = new Client();

            Abstraction abstraction;
            // El código de cliente debería poder funcionar con cualquier combinación
            // preconfigurada de abstracción-implementación.
            abstraction = new Abstraction(new ConcreteImplementationA());
            client.ClientCode(abstraction);

            Console.WriteLine("\n");

            abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
            client.ClientCode(abstraction);

            Console.WriteLine("\n");
        }
    }
}
