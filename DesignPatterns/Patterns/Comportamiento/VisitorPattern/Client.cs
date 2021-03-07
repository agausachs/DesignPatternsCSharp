using System;
using System.Collections.Generic;

namespace DesignPatterns.Patterns.Comportamiento.VisitorPattern
{
    public class Client
    {
        // El código cliente puede ejecutar operaciones de visitante sobre cualquier conjunto de elementos
        // sin averiguar sus clases concretas. La operación `Accept`
        // dirige una llamada a la operación apropiada en el objeto visitante.
        public static void ClientCode(List<IComponent> components, IVisitor visitor)
        {
            foreach (var component in components)
            {
                component.Accept(visitor);
            }
        }
    }
}
