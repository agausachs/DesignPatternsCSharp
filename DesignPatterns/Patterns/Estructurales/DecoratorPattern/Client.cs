using System;
namespace DesignPatterns.Patterns.Estructurales.DecoratorPattern
{
    public class Client
    {
        // El código del cliente funciona con todos los objetos que utilizan la interfaz del componente.
        // De esta manera puede permanecer independiente de las clases concretas de
        // componentes con los que trabaja.
        public void ClientCode(Component component)
        {
            Console.WriteLine("RESULT: " + component.Operation());
        }
    }
}
