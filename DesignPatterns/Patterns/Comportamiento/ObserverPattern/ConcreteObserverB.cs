﻿using System;
namespace DesignPatterns.Patterns.Comportamiento.ObserverPattern
{
    public class ConcreteObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State == 0 || (subject as Subject).State >= 2)
            {
                Console.WriteLine("ConcreteObserverB: Reaccionado al evento.");
            }
        }
    }
}
