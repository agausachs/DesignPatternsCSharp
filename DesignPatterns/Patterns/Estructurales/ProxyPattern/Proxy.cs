using System;
namespace DesignPatterns.Patterns.Estructurales.ProxyPattern
{
    // El Proxy tiene un interface idéntico al RealSubject.
    public class Proxy : ISubject
    {
        private RealSubject _realSubject;

        public Proxy(RealSubject realSubject)
        {
            _realSubject = realSubject;
        }

        // Las aplicaciones más comunes del patrón Proxy son la carga diferida,
        // almacenamiento en caché, control de acceso, registro, etc. Un proxy puede realizar
        // una de estas cosas y luego, dependiendo del resultado, pasar la
        // ejecución al mismo método en un objeto RealSubject vinculado.
        public void Request()
        {
            if (this.CheckAccess())
            {
                _realSubject.Request();

                this.LogAccess();
            }
        }

        public bool CheckAccess()
        {
            Console.WriteLine("Proxy: Comprobando el acceso antes de disparar realmente el request");

            return true;
        }

        public void LogAccess()
        {
            Console.WriteLine($"Proxy: Logando el timestamp de la request. {DateTime.Now.ToString()}");
        }
    }
}
