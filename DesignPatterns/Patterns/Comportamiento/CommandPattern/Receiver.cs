using System;

namespace DesignPatterns.Patterns.Comportamiento.CommandPattern
{
    // Las clases del receptor contienen una lógica de negocio importante. Ellos saben como
    // realizar todo tipo de operaciones, asociadas a la realización de un
    // petición. De hecho, cualquier clase puede servir como Receptor.
    public class Receiver
    {
        public void DoSomething(string a)
        {
            Console.WriteLine($"Receiver: Trabajando en ({a}.)");
        }

        public void DoSomethingElse(string b)
        {
            Console.WriteLine($"Receiver: También trabajando en ({b}.)");
        }
    }
}