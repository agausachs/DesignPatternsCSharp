using System;
namespace DesignPatterns.Patterns.Comportamiento.IteratorPattern
{
    public static class IteratorPatternProgram
    {
        public static void Run()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine(" ITERATOR PATTERN ");
            Console.WriteLine("-------------------------");

            // El código del cliente puede saber o no sobre el iterador concreto
            // o clases de colección, dependiendo del nivel de indirección que
            // desees mantener en el programa.
            WordsCollection collection = new WordsCollection();
            collection.AddItem("Primero");
            collection.AddItem("Segundo");
            collection.AddItem("Tercero");

            Console.WriteLine("Travesía recta:");

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nRecorrido inverso");

            collection.ReverseDirection();

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\n");
        }
    }
}
