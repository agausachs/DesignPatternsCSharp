using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Patterns.Comportamiento.MementoPattern
{
    // El Caretaker no depende de la clase Concrete Memento. Por lo tanto
    // no tiene acceso al estado del creador, almacenado dentro del memento.
    // Funciona con todos los mementos a través de la interfaz base de Memento.
    public class Caretaker
    {
        private List<IMemento> _mementos = new List<IMemento>();

        private Originator _originator = null;

        public Caretaker(Originator originator)
        {
            _originator = originator;
        }

        public void Backup()
        {
            Console.WriteLine("\nCaretaker: Guardando estado del Originator...");
            _mementos.Add(_originator.Save());
        }

        public void Undo()
        {
            if (_mementos.Count == 0)
            {
                return;
            }

            IMemento memento = _mementos.Last();

            _mementos.Remove(memento);

            Console.WriteLine("Caretaker: Restaurando estado a: " + memento.GetName());

            try
            {
                _originator.Restore(memento);
            }
            catch (Exception)
            {
                Undo();
            }
        }

        public void ShowHistory()
        {
            Console.WriteLine("Caretaker: Aquí está la lista de mementos:");

            foreach (IMemento memento in _mementos)
            {
                Console.WriteLine(memento.GetName());
            }
        }
    }
}
