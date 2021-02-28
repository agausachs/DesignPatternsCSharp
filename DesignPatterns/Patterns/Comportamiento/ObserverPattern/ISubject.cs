namespace DesignPatterns.Patterns.Comportamiento.ObserverPattern
{
    public interface ISubject
    {
        // Vincula un observer a un sujeto.
        void Attach(IObserver observer);

        // Desvincula un observer del sujeto.
        void Detach(IObserver observer);

        // Notifica a todos los observadores a un evento.
        void Notify();
    }
}