namespace DesignPatterns.Patterns.Comportamiento.MediatorPattern
{
    // La interfaz del Mediador declara un método utilizado por los componentes para notificar al
    // mediador sobre varios eventos. El Mediador puede reaccionar a estos eventos y
    // pasar la ejecución a otros componentes.
    public interface IMediator
    {
        void Notify(object sender, string ev);
    }
}
