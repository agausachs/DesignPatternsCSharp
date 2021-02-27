using System;
using System.Collections.Generic;

namespace DesignPatterns.Patterns.Comportamiento.ChainOfResponsibilityPattern
{
    public class Client
    {
        // El código del cliente suele ser adecuado para trabajar con un solo controlador. En
        // la mayoría de los casos, ni siquiera se da cuenta de que el manejador es parte de una cadena.
        public static void ClientCode(AbstractHandler handler)
        {
            foreach (string food in new List<string>{ "Nuez", "Banana", "Taza de café" })
            {
                Console.WriteLine($"Client: Quién quiere una {food}?");

                object result = handler.Handle(food);

                if (result != null)
                {
                    Console.Write($"    {result}");
                }
                else
                {
                    Console.WriteLine($"   {food} ha sido ignorada.");
                }
            }
        }
    }
}
