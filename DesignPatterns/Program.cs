using DesignPatterns.Patterns.BuilderPattern;
using DesignPatterns.Patterns.FactoryMethodPattern;
using DesignPatterns.SolidPrinciples.SingleResponsibility;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            BuilderPatternProgram.Run();

            FactoryMethodPatternProgram.Run();

            // SOLID

            SRPProgram.Run();

            Console.WriteLine("\n");
        }
    }
}
