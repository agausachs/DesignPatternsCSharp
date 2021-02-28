using System;

namespace DesignPatterns.Patterns.Comportamiento.StatePattern
{
    // La clase base State declara métodos que todo Estado concreto debería
    // implementar y también proporciona una referencia inversa al objeto Context,
    // asociado al Estado. Los Estados pueden utilizar esta referencia inversa para
    // hacer la transición del contexto a otro estado.
    public abstract class State
    {
        protected Context _context;

        public void SetContext(Context context)
        {
            _context = context;
        }

        public abstract void Handle1();

        public abstract void Handle2();
    }
}