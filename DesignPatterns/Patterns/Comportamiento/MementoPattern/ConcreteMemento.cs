using System;

namespace DesignPatterns.Patterns.Comportamiento.MementoPattern
{
    // El Concrete Memento contiene la infraestructura para almacenar el
    // estado del originador.
    public class ConcreteMemento : IMemento
    {
        private string _state;

        private DateTime _date;

        public ConcreteMemento(string state)
        {
            _state = state;
            _date = DateTime.Now;
        }

        public DateTime GetDate()
        {
            return _date;
        }

        // El resto de metodos son usados por el Caretaker para mostrar metadatos.
        public string GetName()
        {
            return $"{_date} / ({_state.Substring(0, 9)})...";
        }

        // El Originator usa este método cuando restaura su estado.
        public string GetState()
        {
            return _state;
        }
    }
}