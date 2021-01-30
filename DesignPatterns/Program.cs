using DesignPatterns.Patterns.BuilderPattern;
using DesignPatterns.Patterns.FactoryMethodPattern;
using DesignPatterns.SolidPrinciples.OpenClosed;
using DesignPatterns.SolidPrinciples.SingleResponsibility;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // PATTERNS

            BuilderPatternProgram.Run();

            FactoryMethodPatternProgram.Run();

            // SOLID

            SRPProgram.Run();

            OCPProgram.Run();

            Console.WriteLine("\n");
        }
    }
}
