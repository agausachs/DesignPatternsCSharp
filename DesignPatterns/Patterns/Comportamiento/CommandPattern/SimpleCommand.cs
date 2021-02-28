using System;
namespace DesignPatterns.Patterns.Comportamiento.CommandPattern
{
    // Algunos comandos pueden implementar operaciones simples por ellos mismos.
    public class SimpleCommand : ICommand
    {
        private string _payload = string.Empty;

        public SimpleCommand(string payload)
        {
            _payload = payload;
        }

        public void Execute()
        {
            Console.WriteLine($"SimpleCommand: Mira, puedo hacer cosas simples como printar ({_payload})");
        }
    }
}
