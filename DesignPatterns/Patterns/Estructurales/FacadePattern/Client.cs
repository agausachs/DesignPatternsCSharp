using System;
namespace DesignPatterns.Patterns.Estructurales.FacadePattern
{
    public class Client
    {
        // El código del cliente trabaja con subsistemas complejos a través de un simple
        // interfaz proporcionado por la Fachada. Cuando una fachada gestiona el ciclo de vida
        // del subsistema, es posible que el cliente ni siquiera conozca la existencia
        // del subsistema. Este enfoque le permite mantener la complejidad bajo
        // control.
        public static void ClientCode(Facade facade)
        {
            Console.WriteLine(facade.Operation());
        }
    }
}
