using System;
namespace DesignPatterns.Patterns.Estructurales.CompositePattern
{
    // La clase base Component declara operaciones comunes tanto para simples como para
    // objetos complejos de una composición.
    public abstract class Component
    {
        public Component(){}

        // El componente base puede implementar algún comportamiento predeterminado o dejarlo
        // a las clases concretas (declarando el método que contiene el comportamiento como
        // "abstracto").
        public abstract string Operation();

        // En algunos casos, sería beneficioso definir las operaciones de la gestión de los nodos
        // hijos directamente en la clase Component base. De esta manera, no 
        // necesitarás exponer cualquier clase de componente concreto al código del cliente,
        // incluso durante el ensamblaje del árbol de objetos. La desventaja es que estos
        // métodos estarán vacíos para los componentes de nivel de hoja.
        public virtual void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(Component component)
        {
            throw new NotImplementedException();
        }

        // Puedes proveer de un método que permite al código cliente averiguar
        // si un componente puede tener hijos.
        public virtual bool IsComposite()
        {
            return true;
        }
    }
}
