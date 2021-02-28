using System;
namespace DesignPatterns.Patterns.Comportamiento.CommandPattern
{

    // La interficie Command declara un método para ejecutar un comando.
    public interface ICommand
    {
        void Execute();
    }
}
