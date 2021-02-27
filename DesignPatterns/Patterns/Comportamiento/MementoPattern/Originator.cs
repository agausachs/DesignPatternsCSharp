using System;
using System.Threading;

namespace DesignPatterns.Patterns.Comportamiento.MementoPattern
{
    // El originator tiene algún estado importante que puede cambiar con el tiempo.
    // También define un método para guardar el estado dentro de un memento (recuerdo) y otro
    // método para restaurar el estado a partir de él.
    public class Originator
    {
        // En aras de la simplicidad, el estado del originador se almacena dentro de una
        // variable única.
        private string _state;

        public Originator(string state)
        {
            _state = state;
            Console.WriteLine("Originator: Mi estado inicial es: " + state);
        }

        // La lógica de negocio del Originator puede afectar su estado interno.
        // Por lo tanto, el cliente debe hacer una copia de seguridad del estado antes de iniciar
        // métodos de la lógica de negocio mediante el método save().
        public void DoSomething()
        {
            Console.WriteLine("Originator: Estoy haciendo algo importante.");
            _state = GenerateRandomString(30);
            Console.WriteLine($"Originator: y mi estado ha cambiado a: {_state}");
        }

        private string GenerateRandomString(int length = 10)
        {
            string allowedSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string result = string.Empty;

            while (length > 0)
            {
                result += allowedSymbols[new Random().Next(0, allowedSymbols.Length)];

                Thread.Sleep(12);

                length--;
            }

            return result;
        }

        // Guarda el estado actual dentro de un memento.
        public IMemento Save()
        {
            return new ConcreteMemento(_state);
        }

        // Restaura el estado del Originator a partir de un objeto memento.
        public void Restore(IMemento memento)
        {
            if (!(memento is ConcreteMemento))
            {
                throw new Exception("Clase memento desconocida " + memento.ToString());
            }

            _state = memento.GetState();
            Console.WriteLine($"Originator: Mi estado ha cambiado a: {_state}");
        }
    }
}
