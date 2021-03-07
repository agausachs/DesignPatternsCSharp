using System;
using DesignPatterns.Patterns.Comportamiento.ChainOfResponsibilityPattern;
using DesignPatterns.Patterns.Comportamiento.CommandPattern;
using DesignPatterns.Patterns.Comportamiento.IteratorPattern;
using DesignPatterns.Patterns.Comportamiento.MediatorPattern;
using DesignPatterns.Patterns.Comportamiento.MementoPattern;
using DesignPatterns.Patterns.Comportamiento.ObserverPattern;
using DesignPatterns.Patterns.Comportamiento.StatePattern;
using DesignPatterns.Patterns.Comportamiento.StrategyPattern;
using DesignPatterns.Patterns.Comportamiento.TemplateMethodPattern;
using DesignPatterns.Patterns.Creacionales.AbstractFactoryPattern;
using DesignPatterns.Patterns.Creacionales.BuilderPattern;
using DesignPatterns.Patterns.Creacionales.FactoryMethodPattern;
using DesignPatterns.Patterns.Creacionales.PrototypePattern;
using DesignPatterns.Patterns.Creacionales.SingletonPattern;
using DesignPatterns.Patterns.Estructurales.AdapterPattern;
using DesignPatterns.Patterns.Estructurales.BridgePattern;
using DesignPatterns.Patterns.Estructurales.CompositePattern;
using DesignPatterns.Patterns.Estructurales.DecoratorPattern;
using DesignPatterns.Patterns.Estructurales.FacadePattern;
using DesignPatterns.Patterns.Estructurales.FlyweightPattern;
using DesignPatterns.Patterns.Estructurales.ProxyPattern;
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
            // PATTERNS CREACIONALES

            BuilderPatternProgram.Run();

            FactoryMethodPatternProgram.Run();

            SingletonPatternProgram.Run();

            AbstractFactoryPatternProgram.Run();

            PrototypePatternProgram.Run();


            // PATTERNS ESTRUCTURALES

            AdapterPatternProgram.Run();

            CompositePatternProgram.Run();

            FacadePatternProgram.Run();

            ProxyPatternProgram.Run();

            BridgePatternProgram.Run();

            DecoratorPatternProgram.Run();

            FlyweightPatternProgram.Run();


            // PATTERNS DE COMPORTAMIENTO

            ChainOfResponsibilityPatternProgram.Run();

            IteratorPatternProgram.Run();

            MementoPatternProgram.Run();

            StatePatternProgram.Run();

            TemplateMethodPatternProgram.Run();

            CommandPatternProgram.Run();

            MediatorPatternProgram.Run();

            ObserverPatternProgram.Run();

            StrategyPatternProgram.Run();

            //VisitorPatternProgram.Run();


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
