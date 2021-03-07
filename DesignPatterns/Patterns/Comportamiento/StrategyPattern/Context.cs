using System;
using System.Collections.Generic;

namespace DesignPatterns.Patterns.Comportamiento.StrategyPattern
{
    // El contexto define el interface de interés para los clientes.
    public class Context
    {
        // El contexto mantiene una referencia a uno de los objetos de estrategia.
        // El contexto no conoce la clase concreta de una estrategia. Debería poder
        // trabajar con todas las estrategias a través de la interfaz de estrategia.
        private IStrategy _strategy;

        public Context()
        {}

        // Por lo general, el contexto acepta una estrategia a través del constructor, pero
        // también proporciona un setter para cambiarlo en tiempo de ejecución.
        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        // Normalmente, el Contexto permite reemplazar un objeto Strategy en tiempo de ejecución.
        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        // El contexto delega algo de trabajo al objeto Estrategia en lugar de
        // implementar múltiples versiones del algoritmo por sí solo.
        public void DoSomeBusinessLogic()
        {
            Console.WriteLine("Context: Ordenando datos usando la estrategia (no estoy seguro como lo haré)");

            var result = _strategy.DoAlgorithm(new List<string> { "a", "b", "c", "d", "e" });

            string resultStr = string.Empty;

            foreach (var element in result as List<string>)
            {
                resultStr += element + ",";
            }

            Console.WriteLine(result);
        }
    }
}
