namespace DesignPatterns.Patterns.Comportamiento.ChainOfResponsibilityPattern
{
    // El comportamiento de encadenamiento predeterminado se puede implementar
    // dentro de una clase controladora base.
    public class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;

            // Devolver un controlador desde aquí nos permitirá vincular los controladores en un
            // forma conveniente como esta:
            // mono.SetNext (ardilla) .SetNext (perro);
            // A esto en se le suele llamar Fluent Interface.
            return handler;
        }

        public virtual object Handle(object request)
        {
            if (_nextHandler != null)
            {
                return _nextHandler.Handle(request);
            }
            else
            {
                return null;
            }
        }
    }
}
