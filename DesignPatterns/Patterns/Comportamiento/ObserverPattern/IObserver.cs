using System;

namespace DesignPatterns.Patterns.Comportamiento.ObserverPattern
{
    public interface IObserver
    {
        // Recibe actualizaciones de un sujeto
        void Update(ISubject subject);
    }
}
