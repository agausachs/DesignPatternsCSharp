namespace DesignPatterns.Patterns.SingletonPattern
{
    // Esta implementación de Singleton se llama "bloqueo de doble verificación". Es seguro
    // en un entorno multiproceso y proporciona una inicialización diferida para el
    // Objeto singleton.
    public class SingletonThreadSafe
    {
        private static SingletonThreadSafe _instancia;

        // Ahora tenemos un objeto de bloqueo que se utilizará para sincronizar hilos
        // durante el primer acceso al Singleton.
        private static readonly object _bloqueo = new object();

        // Usaremos esta propiedad para probar que el Singleton funciona correctamente.
        public string Value { get; set; }

        private SingletonThreadSafe(){}

        public static SingletonThreadSafe GetInstancia(string value)
        {
            // Este condicional es necesario para evitar que los subprocesos tropiecen con el
            // bloquear una vez que la instancia esté lista.
            if (_instancia == null)
            {
                // Ahora, imagina que el programa acaba de lanzarse. Ya que
                // todavía no hay una instancia de Singleton, varios subprocesos pueden
                // pasar simultáneamente el condicional anterior y llegar a este
                // punto casi al mismo tiempo. El primero de ellos adquirirá
                // bloquear y continuará, mientras que el resto esperará aquí.
                lock (_bloqueo)
                {
                    // El primer hilo en adquirir el bloqueo, llega a este
                    // condicional, entra y crea la instancia del Singleton.
                    // Una vez que sale del bloque de bloqueo, un hilo que
                    // podría haber estado esperando la liberación de bloqueo puede entonces
                    // entrar en esta sección. Pero dado que el campo Singleton ya ha sid
                    // inicializado, el hilo no creará un nuevo objeto.
                    if (_instancia == null)
                    {
                        _instancia = new SingletonThreadSafe();
                        _instancia.Value = value;
                    }
                }
            }

            return _instancia;
        }
    }
}
