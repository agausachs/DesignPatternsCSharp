using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Patterns.Estructurales.FlyweightPattern
{
    // La Flyweight Factory crea y gestiona los objetos Flyweight. Eso
    // asegura que los Flyweight se compartan correctamente. Cuando el cliente solicita un
    // Flyweight, la fábrica devuelve una instancia existente o crea una
    // una nuevo, si aún no existe.
    public class FlyweightFactory
    {
        private List<Tuple<Flyweight, string>> flyweights = new List<Tuple<Flyweight, string>>();

        public FlyweightFactory(params Car[] args)
        {
            foreach (Car elem in args)
            {
                flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(elem), GetKey(elem)));
            }
        }

        // Devuelve el hash de cadena de Flyweight para un estado determinado.
        public string GetKey(Car key)
        {
            List<string> elements = new List<string>
            {
                key.Model,
                key.Color,
                key.Company
            };

            if (key.Owner != null && key.Number != null)
            {
                elements.Add(key.Number);
                elements.Add(key.Owner);
            }

            elements.Sort();

            return string.Join("_", elements);
        }

        // Devuelve un Flyweight existente con un estado dado o crea uno nuevo.
        public Flyweight GetFlyweight(Car sharedState)
        {
            string key = GetKey(sharedState);

            if (!flyweights.Where(t => t.Item2 == key).Any())
            {
                Console.WriteLine("FlyweightFactory: No puedo encontrar un flyweight, creo uno nuevo");
                this.flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(sharedState), key));
            }
            else
            {
                Console.WriteLine("FlyweightFactory: Reusando un flyweight existente");
            }
            return flyweights.Where(t => t.Item2 == key).FirstOrDefault().Item1;
        }

        public void ListFlyWeights()
        {
            int count = flyweights.Count;
            Console.WriteLine($"\nFlyweightFactory: Tengo {count} flyweights:");
            foreach (Tuple<Flyweight, string> flyweight in flyweights)
            {
                Console.WriteLine(flyweight.Item2);
            }
        }
    }
}
