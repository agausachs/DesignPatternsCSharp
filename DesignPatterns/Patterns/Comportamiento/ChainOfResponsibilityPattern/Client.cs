using System;
using System.Collections.Generic;

namespace DesignPatterns.Patterns.Comportamiento.ChainOfResponsibilityPattern
{
    public class Client
    {
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
