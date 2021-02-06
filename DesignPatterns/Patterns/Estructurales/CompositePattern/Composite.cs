using System;
using System.Collections.Generic;

namespace DesignPatterns.Patterns.Estructurales.CompositePattern
{
    public class Composite : Component
    {
        protected List<Component> _children = new List<Component>();

        public override void Add(Component component)
        {
            _children.Add(component);
        }

        public override void Remove(Component component)
        {
            _children.Remove(component);
        }

        // El Composite (compuesto) ejecuta su lógica primaria de una manera particular. Eso
        // atraviesa recursivamente a través de todos sus hijos, recogiendo y
        // sumando sus resultados. Dado que los hijos del compuesto pasan estas
        // llamadas a sus hijos y así sucesivamente, todo el árbol de objetos es
        // atravesado como resultado.
        public override string Operation()
        {
            int i = 0;
            string result = "Rama(";

            foreach (Component component in _children)
            {
                result += component.Operation();
                if (i != _children.Count - 1)
                {
                    result += "+";
                }
                i++;
            }

            return result + ")";
        }
    }
}
