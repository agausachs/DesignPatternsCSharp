using System.Collections;

namespace DesignPatterns.Patterns.Comportamiento.IteratorPattern
{
    public abstract class Iterator : IEnumerator
    {
        object IEnumerator.Current => Current();

        // Devuelve la clave del elemento actual
        public abstract int Key();

        // Devuelve el elemento actual
        public abstract object Current();

        // Avanza al siguiente elemento
        public abstract bool MoveNext();

        // Rebobina el Iterator hasta el primer elemento
        public abstract void Reset();
    }
}
