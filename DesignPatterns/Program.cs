using System;
using DesignPatterns.Patterns.AbstractFactoryPattern;
using DesignPatterns.Patterns.BuilderPattern;
using DesignPatterns.Patterns.FactoryMethodPattern;
using DesignPatterns.Patterns.SingletonPattern;
using DesignPatterns.SolidPrinciples.DependencyInversion;
using DesignPatterns.SolidPrinciples.InterfaceSegregation;
using DesignPatterns.SolidPrinciples.LiskovSubstitution;
using DesignPatterns.SolidPrinciples.OpenClosed;
using DesignPatterns.SolidPrinciples.SingleResponsibility;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // PATTERNS

            BuilderPatternProgram.Run();

            FactoryMethodPatternProgram.Run();

            SingletonPatternProgram.Run();

            AbstractFactoryPatternProgram.Run();

            // SOLID PRINCIPLES

            SRPProgram.Run();

            OCPProgram.Run();

            LSPProgram.Run();

            ISPProgram.Run();

            DIPProgram.Run();

            // End

            Console.WriteLine("\n");
        }
    }
}
