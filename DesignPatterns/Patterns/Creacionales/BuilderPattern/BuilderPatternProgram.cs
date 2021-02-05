using System;
namespace DesignPatterns.Patterns.Creacionales.BuilderPattern
{
    public class BuilderPatternProgram
    {
        public static void Run()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine(" BUILDER PATTERN ");
            Console.WriteLine("-------------------------");

            // El código del cliente crea un objeto builder, se lo pasa al director
            // y entonces inicia el proceso de construcción. El resultado final
            // es recuperado del objeto builder.
            Director director = new Director();
            ConcreteBuilder builder = new ConcreteBuilder();
            director.Buider = builder;

            Console.WriteLine("Producto básico estandard:");
            director.BuildMinimalViableProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Standard full featured product:");
            director.BuildFullFeaturedProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            // Recuerda, el patrón Buider puede ser usado sin clase Director
            Console.WriteLine("Producto personalizado:");
            builder.BuildPartA();
            builder.BuildPartC();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("\n");
        }
    }
}
