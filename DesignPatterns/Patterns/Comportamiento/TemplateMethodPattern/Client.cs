using System;
namespace DesignPatterns.Patterns.Comportamiento.TemplateMethodPattern
{
    public class Client
    {
        // El código del cliente llama al método de plantilla para ejecutar el algoritmo.
        // El código del cliente no tiene que conocer la clase concreta de un objeto con el que
        // trabaja, siempre que funcione con objetos a través de la interfaz de
        // su clase base.
        public static void ClientCode(AbstractClass abstractClass)
        {
            abstractClass.TemplateMethod();
        }
    }
}
