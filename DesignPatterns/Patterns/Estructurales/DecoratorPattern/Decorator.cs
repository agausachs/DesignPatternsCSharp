using System;
namespace DesignPatterns.Patterns.Estructurales.DecoratorPattern
{
    // La clase base Decorator sigue la misma interfaz que el resto de
    // componentes. El propósito principal de esta clase es definir la interfaz
    // envolvente para todos los decoradores concretos. La implementación predeterminada del
    // código envolvente puede incluir un campo para almacenar un componente envuelto y
    // los medios para inicializarlo.
    public abstract class Decorator : Component
    {
        protected Component _component;

        public Decorator(Component component)
        {
            _component = component;
        }

        public void SetComponent(Component component)
        {
            _component = component;
        }

        // El Decorador delega todo el trabajo al componente envuelto.
        public override string Operation()
        {
            if (_component != null)
            {
                return _component.Operation();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
