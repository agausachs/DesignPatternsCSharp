using System;
namespace DesignPatterns.Patterns.Estructurales.AdapterPattern
{
    public static class AdapterPatternProgram
    {
        public static void Run()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine(" ADAPTER PATTERN ");
            Console.WriteLine("-------------------------");

            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);

            Console.WriteLine("La interfaz del Adaptee es incompatible con el cliente.");
            Console.WriteLine("Pero el cliente adapter puede llamar a su método.");

            Console.WriteLine(target.GetRequest());

            Console.WriteLine("\n");
        }
    }
}
