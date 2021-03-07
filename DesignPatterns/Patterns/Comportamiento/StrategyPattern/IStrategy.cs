using System.Collections.Generic;

namespace DesignPatterns.Patterns.Comportamiento.StrategyPattern
{
    // La interfaz de la estrategia declara operaciones comunes a todas las versiones
    // admitidas de algún algoritmo.
    //
    // El contexto usa esta interfaz para llamar al algoritmo definido por estrategias concretas.
    public interface IStrategy
    {
        object DoAlgorithm(object data);
    }
}