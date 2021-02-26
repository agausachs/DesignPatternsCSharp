using System;
namespace DesignPatterns.Patterns.Estructurales.ProxyPattern
{
    public static class ProxyPatternProgram
    {
        public static void Run()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine(" PROXY PATTERN ");
            Console.WriteLine("-------------------------");


            Client client = new Client();

            Console.WriteLine("Client: Ejecutando el código del cliente con un RealSubject:");
            RealSubject realSubject = new RealSubject();
            client.ClientCode(realSubject);

            Console.WriteLine("\n");

            Console.WriteLine("Client: Ejecutando el mismo código del cliente pero a través del proxy");
            Proxy proxy = new Proxy(realSubject);
            client.ClientCode(proxy);

            Console.WriteLine("\n");
        }
    }
}
