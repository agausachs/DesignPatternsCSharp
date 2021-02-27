namespace DesignPatterns.Patterns.Comportamiento.ChainOfResponsibilityPattern
{
    // La interfaz Handler declara un método para construir la cadena de
    // manipuladores. También declara un método para ejecutar una solicitud.
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);

        object Handle(object request);
    }
}
