using System;
namespace DesignPatterns.Patterns.Comportamiento.CommandPattern
{
    // Aunque algunos comandos pueden delegar operaciones más complejas a otros
    // objetos, llamados "receptores".
    public class ComplexCommand : ICommand
    {
        private Receiver _receiver;

        // Datos del contexto, requeridos para lanzar los métodos del receptor.
        private string _a;

        private string _b;

        // Los comandos complejos pueden aceptar uno o varios objetos receptores junto
        // con cualquier dato de contexto vía constructor.
        public ComplexCommand(Receiver receiver, string a, string b)
        {
            _receiver = receiver;
            _a = a;
            _b = b;
        }

        // Los comandos pueden delegar a cualquier método del receptor.
        public void Execute()
        {
            Console.WriteLine("ComplexCommand: Cosas complejas deberían ser hechas por un objeto receptor.");
            _receiver.DoSomething(_a);
            _receiver.DoSomething(_b);
        }
    }
}
