using System;
namespace DesignPatterns.SolidPrinciples.LiskovSubstitution
{
    // LSP establece que la clase secundaria debe ser perfectamente sustituible
    // por la clase principal. Si la clase C se deriva de P, entonces C debería ser
    // sustituible por P.
    //
    // Podemos comprobar mediante LSP que la herencia se aplica correctamente
    // o no en nuestro código. LSP es un principio fundamental de los principios de SOLID
    // y establece que si el programa o módulo está usando la clase base, la clase derivada
    // debería poder extender su clase base sin cambiar su implementación original.
    public static class LSPProgram
    {
        public static void Run()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine(" LISKOV SUBSTITUTION PRINCIPLE ");
            Console.WriteLine("-------------------------");

            Console.WriteLine("\n");

            Console.WriteLine(" BAD SHAPE TRIANGLE");
            BadTriangle badTriangle = new BadCircle();
            Console.Write(badTriangle.GetShape());

            Console.WriteLine("\n");

            Console.WriteLine(" GOOD SHAPE CIRCLE - TRIANGLE");
            GoodShape shape = new GoodCircle();
            Console.WriteLine(shape.GetShape());

            shape = new GoodTriangle();
            Console.WriteLine(shape.GetShape());

            Console.WriteLine("\n");
        }
    }
}
