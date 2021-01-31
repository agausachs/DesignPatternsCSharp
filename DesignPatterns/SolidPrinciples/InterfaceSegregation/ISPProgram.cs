using System;
namespace DesignPatterns.SolidPrinciples.InterfaceSegregation
{
    // Definición: Ningún cliente debe verse obligado a implementar métodos que no utilice,
    // y los contratos deben dividirse en pequeños. Se requiere el principio de segregación
    // de interfaz para resolver el problema de diseño de la aplicación. Cuando todas las
    // tareas las realiza una sola clase o, en otras palabras, una clase se usa en casi
    // todas las clases de aplicación, entonces se ha convertido en una clase gruesa
    // con sobrecarga. Heredar dicha clase dará como resultado tener métodos de intercambio
    // que no son relevantes para las clases derivadas, pero están allí en la clase base,
    // por lo que heredarán en la clase derivada.
    //
    // Con ISP, podemos crear interfaces separadas para cada operación o requisito en lugar
    // de tener una sola clase para hacer el mismo trabajo.
    public static class ISPProgram
    {
        public static void Run()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine(" INTERFACE SEGREGATION PRINCIPLE ");
            Console.WriteLine("-------------------------");

            Console.WriteLine("\n");

            Console.WriteLine(" BAD ONLINE ORDER ");
            BadOnlineOrder badOnlineOrder = new BadOnlineOrder();
            Console.WriteLine(badOnlineOrder.AddToCart());
            Console.WriteLine(badOnlineOrder.CCProcess());

            Console.WriteLine("\n");

            Console.WriteLine(" BAD OFFLINE ORDER ");
            BadOfflineOrder badOfflineOrder = new BadOfflineOrder();
            Console.WriteLine(badOfflineOrder.AddToCart());
            Console.WriteLine(badOfflineOrder.CCProcess());


            Console.WriteLine("\n");

            Console.WriteLine(" GOOD ONLINE ORDER ");
            GoodOnlineOrder goodOnlineOrder = new GoodOnlineOrder();
            Console.WriteLine(goodOnlineOrder.AddToCart());
            Console.WriteLine(goodOnlineOrder.CCProcess());

            Console.WriteLine(" GOOD OFFLINE ORDER ");
            GoodOfflineOrder goodOfflineOrder = new GoodOfflineOrder();
            Console.WriteLine(goodOfflineOrder.AddToCart());

            Console.WriteLine("\n");
        }
    }
}
