using System;
using System.Collections.Generic;

namespace DesignPatterns.Patterns.Comportamiento.StrategyPattern
{
    // Las estrategias concretas implementan el algoritmo siguiendo la interfaz estrategia base.
    // La interfaz los hace intercambiables en el Contexto.
    public class ConcreteStrategyA : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            var list = data as List<string>;

            list.Sort();

            return list;
        }
    }
}
