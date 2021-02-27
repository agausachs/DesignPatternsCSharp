using System;
namespace DesignPatterns.Patterns.Estructurales.FlyweightPattern
{
    public static class FlyweightPatternProgram
    {
        public static void Run()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine(" FLYWEIGHT PATTERN ");
            Console.WriteLine("-------------------------");

            // El código cliente normalmente crea un montón de flyweights
            // pre-rellenados en la fase de inicialización de la aplicación.
            FlyweightFactory factory = new FlyweightFactory(
                new Car { Company = "Chevrolet", Model = "Camaro2018", Color = "pink" },
                new Car { Company = "Mercedes Benz", Model = "C300", Color = "black" },
                new Car { Company = "Mercedes Benz", Model = "C500", Color = "red" },
                new Car { Company = "BMW", Model = "M5", Color = "red" },
                new Car { Company = "BMW", Model = "X6", Color = "white" }
            );
            factory.ListFlyWeights();

            addCarToPoliceDatabase(factory, new Car
            {
                Number = "CL234IR",
                Owner = "James Doe",
                Company = "BMW",
                Model = "M5",
                Color = "red"
            });

            addCarToPoliceDatabase(factory, new Car
            {
                Number = "CL234IR",
                Owner = "James Doe",
                Company = "BMW",
                Model = "X1",
                Color = "red"
            });

            factory.ListFlyWeights();

            Console.WriteLine("\n");
        }

        public static void addCarToPoliceDatabase(FlyweightFactory factory, Car car)
        {
            Console.WriteLine("\nCliente: Añadiendo coche a la base de datos");

            var flyweight = factory.GetFlyweight(new Car
            {
                Color = car.Color,
                Model = car.Model,
                Company = car.Company
            });

            // El código del cliente almacena o calcula el estado extrínseco y
            // lo pasa a los métodos del Flyweight.
            flyweight.Operation(car);
        }
    }
}
