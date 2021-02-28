using System;
namespace DesignPatterns.Patterns.Comportamiento.StatePattern
{
    // El contexto define la interfaz de interés para los clientes. También
    // mantiene una referencia a una instancia de una subclase de estado, que
    // representa el estado actual del contexto.
    public class Context
    {
        // Una referencia al estado actual del contexto.
        private State _state = null;

        public Context(State state)
        {
            TransitionTo(state);
        }

        // El contexto permite cambiar el estado del objeto en runtime.
        public void TransitionTo(State state)
        {
            Console.WriteLine($"Context: Transición a {state.GetType().Name}.");
            _state = state;
            _state.SetContext(this);
        }

        // El contexto delega parte de su comportamiento al objeto de estado actual.
        public void Request1()
        {
            _state.Handle1();
        }

        public void Request2()
        {
            _state.Handle2();
        }
    }
}
