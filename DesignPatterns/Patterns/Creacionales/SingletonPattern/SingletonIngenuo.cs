using System;
namespace DesignPatterns.Patterns.Creacionales.SingletonPattern
{
    // La clase Singleton define el método `GetInstancia` que sirve como
    // alternativa al constructor y permite a los clientes acceder a la misma instancia de
    // esta clase una y otra vez. 
    public class SingletonIngenuo
    {
        // La instancia de Singleton se almacena en un campo estático. Hay 
        // múltiples formas de inicializar este campo, todas tienen varias ventajas
        // y contras. En este ejemplo, mostraremos la más simple de estas formas,
        // que, sin embargo, no funciona muy bien en programas multiproceso.
        private static SingletonIngenuo _instancia;

        // El constructor de Singleton siempre debe ser privado para evitar
        // llamadas de construcción directas con el operador `new`.
        private SingletonIngenuo(){}

        // Este es el método estático que controla el acceso a la instancia del singleton.
        // En la primera ejecución, crea un objeto singleton y colocalo
        // en el campo estático. En ejecuciones posteriores, devuelve el objeto 
        // existente almacenado en el campo estático.
        public static SingletonIngenuo GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new SingletonIngenuo();
            }
            return _instancia;
        }

        public static void AlgunProcesoLogico()
        {
            // ...∫
        }
    }
}
