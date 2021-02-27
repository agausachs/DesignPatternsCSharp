using System;
namespace DesignPatterns.Patterns.Comportamiento.MediatorPattern
{
    // El Componente Base proporciona la funcionalidad básica de almacenar una
    // instancia del mediador dentro de los objetos componentes.
    public class BaseComponent
    {
        protected IMediator _mediator;

        public BaseComponent(IMediator mediator = null)
        {
            _mediator = mediator;
        }

        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
