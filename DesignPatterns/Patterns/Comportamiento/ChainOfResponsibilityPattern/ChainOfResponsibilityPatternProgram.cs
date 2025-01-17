﻿using System;
namespace DesignPatterns.Patterns.Comportamiento.ChainOfResponsibilityPattern
{
    public static class ChainOfResponsibilityPatternProgram
    {
       public static void Run()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine(" CHAIN OF RESPONSIBILITY PATTERN ");
            Console.WriteLine("-------------------------");

            // La otra parte del código cliente construye la cadena en cuestión.
            MonkeyHandler monkey = new MonkeyHandler();
            SquirrelHandler squirrel = new SquirrelHandler();
            DogHandler dog = new DogHandler();

            monkey.SetNext(squirrel).SetNext(dog);

            // El cliente debería ser capaz de enviar una request a cualquier manejador,
            // no solo al primero de la cadena.
            Console.WriteLine("Cadena: Mono > Ardilla > Perro\n");
            Client.ClientCode(monkey);
            Console.WriteLine();

            Console.WriteLine("Subcadena: Ardilla > Perro\n");
            Client.ClientCode(squirrel);

            Console.WriteLine("\n");
        }
    }
}
