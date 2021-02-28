using System;
using System.Collections.Generic;
using System.Threading;

namespace DesignPatterns.Patterns.Comportamiento.ObserverPattern
{
    // El Sujeto posee un estado importante y notifica a los observadores cuando el
    // estado cambia.
    public class Subject : ISubject
    {
        // En aras de la simplicidad, el estado del Sujeto, esencial para todos los
        // suscriptores, se almacena en esta variable.
        public int State { get; set; } = -0;

        // Lista de suscriptores. En la vida real, la lista de suscriptores puede ser
        // almacenada de manera más completa (categorizado por tipo de evento, etc.).
        private List<IObserver> _observers = new List<IObserver>();

        // Los métodos de gestión de la suscripción.
        public void Attach(IObserver observer)
        {
            Console.WriteLine("Subject: Vinculado al observador.");
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
            Console.WriteLine("Subject: Desvincula al observador.");
        }

        // Dispara una actualización en cada suscriptor.
        public void Notify()
        {
            Console.WriteLine("Subject: Notificando observadores...");

            foreach (IObserver observer in _observers)
            {
                observer.Update(this);
            }
        }

        // Por lo general, la lógica de suscripción es solo una fracción de lo que un sujeto
        // realmente puede hacer. Los temas suelen tener una lógica de negocio importante,
        // que activa un método de notificación cada vez que algo importante se produce
        // o esta a punto de producirse (o después de eso).
        public void SomeBusinessLogic()
        {
            Console.WriteLine("\nSubject: Estoy haciendo algo importante.");
            State = new Random().Next(0, 10);

            Thread.Sleep(15);

            Console.WriteLine("Subject: Mi estado ha cambiado a: " + State);

            Notify();
        }
    }
}
