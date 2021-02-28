using System;
namespace DesignPatterns.Patterns.Comportamiento.ObserverPattern
{
    // Los observadores concretos reaccionan a las actualizaciones generadas por el Sujeto al que
    // han sido vinculados.
    public class ConcreteObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State < 3)
            {
                Console.WriteLine("ConcreteObserverA: Reaccionado al evento.");
            }
        }
    }
}
