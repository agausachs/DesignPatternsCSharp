using System;
namespace DesignPatterns.Patterns.Estructurales.ProxyPattern
{
    public class Client
    {
        // Se supone que el código del cliente funciona con todos los objetos (ambos sujetos
        // y proxies) a través de la interfaz del sujeto para admitir tanto
        // RealSubjects como proxies. En la vida real, sin embargo, los clientes trabajan principalmente con
        // sus sujetos reales directamente. En este caso, para implementar el patrón
        // más fácilmente, puede extender su proxy desde la clase del sujeto real.
        public void ClientCode(ISubject subject) {

            // ...

            subject.Request();

            // ...

        }
    }
}
