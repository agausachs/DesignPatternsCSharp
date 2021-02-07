using System;
namespace DesignPatterns.Patterns.Estructurales.FacadePattern
{
    public static class FacadePatternProgram
    {
        public static void Run()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine(" FACADE PATTERN ");
            Console.WriteLine("-------------------------");

            // El código cliente puede tener ya creados algunos de los objetos del subsistema.
            // En este caso, puede que valga la pena inicializar la
            // Fachada con estos objetos en lugar de dejar que la Fachada cree
            // nuevas instancias.

            Subsystem1 subsystem1 = new Subsystem1();

            Subsystem2 subsystem2 = new Subsystem2();

            Facade facade = new Facade(subsystem1, subsystem2);

            Client.ClientCode(facade);

            Console.WriteLine("\n");
        }
    }
}
