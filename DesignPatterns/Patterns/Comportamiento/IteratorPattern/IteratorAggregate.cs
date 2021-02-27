using System.Collections;

namespace DesignPatterns.Patterns.Comportamiento.IteratorPattern
{
    public abstract class IteratorAggregate : IEnumerable
    {
        // Retorna un Iterator o otro IteratorAggregate para el objecto
        // implementador.
        public abstract IEnumerator GetEnumerator();
    }
}
