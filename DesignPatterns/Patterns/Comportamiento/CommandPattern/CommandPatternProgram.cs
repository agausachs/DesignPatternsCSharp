using System;
namespace DesignPatterns.Patterns.Comportamiento.CommandPattern
{
    public static class CommandPatternProgram
    {
        public static void Run()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine(" COMMAND PATTERN ");
            Console.WriteLine("-------------------------");

            Console.WriteLine("\n");

            // El código cliente puede parametrizar un invocador con cualquier comando.
            Invoker invoker = new Invoker();
            invoker.SetOnStart(new SimpleCommand("Di Hola!"));
            Receiver receiver = new Receiver();
            invoker.SetOnFinish(new ComplexCommand(receiver, "Enviar email", "Guardar informe"));

            invoker.DoSomethingImportant();

            Console.WriteLine("\n");

        }
    }
}
