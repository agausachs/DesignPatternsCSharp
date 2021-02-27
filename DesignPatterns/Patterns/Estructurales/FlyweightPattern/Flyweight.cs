using System;
using System.Text.Json;

namespace DesignPatterns.Patterns.Estructurales.FlyweightPattern
{
    // El Flyweight almacena una parte común del estado (también llamado estado intrínseco)
    // que pertenece a múltiples entidades reales de negocio. El Flyweight (peso mosca)
    // acepta el resto del estado (estado extrínseco, único para cada entidad)
    // a través de sus parámetros de método.
    public class Flyweight
    {
        private Car _sharedState;

        public Flyweight(Car car)
        {
            _sharedState = car;
        }

        public void Operation(Car uniqueState)
        {
            string s = JsonSerializer.Serialize(_sharedState);
            string u = JsonSerializer.Serialize(uniqueState);

            Console.WriteLine($"Flyweight: Mostrando estado compartido {s} y estado único {u}");
        }
    }
}
