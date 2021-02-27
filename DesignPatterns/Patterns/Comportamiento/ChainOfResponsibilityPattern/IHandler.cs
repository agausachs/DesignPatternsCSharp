namespace DesignPatterns.Patterns.Comportamiento.ChainOfResponsibilityPattern
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);

        object Handle(object request);
    }
}
