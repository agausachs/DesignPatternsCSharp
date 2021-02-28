using System;
namespace DesignPatterns.Patterns.Comportamiento.ObserverPattern
{
    public static class ObserverPatternProgram
    {
        public static void Run()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine(" OBSERVER PATTERN ");
            Console.WriteLine("-------------------------");

            Console.WriteLine("\n");

            // El código cliente.
            Subject subject = new Subject();
            ConcreteObserverA observerA = new ConcreteObserverA();
            subject.Attach(observerA);

            ConcreteObserverB observerB = new ConcreteObserverB();
            subject.Attach(observerB);

            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();

            subject.Detach(observerB);

            subject.SomeBusinessLogic();

            Console.WriteLine("\n");
        }
    }
}
