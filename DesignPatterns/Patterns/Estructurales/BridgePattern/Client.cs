using System;
namespace DesignPatterns.Patterns.Estructurales.BridgePattern
{
    public class Client
    {
        // Excepto para la fase de inicialización, donde un objeto de abstracción se
        // vincula con un objeto de implementación específico, el código del cliente debe
        // solo depender de la clase Abstraction. De esta forma, el código del cliente puede
        // admitir cualquier combinación de abstracción-implementación.
        public void ClientCode(Abstraction abstraction)
        {
            Console.WriteLine(abstraction.Operation());
        }
    }
}
