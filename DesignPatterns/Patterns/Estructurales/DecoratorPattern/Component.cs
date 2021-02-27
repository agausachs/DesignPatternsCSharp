using System;
namespace DesignPatterns.Patterns.Estructurales.DecoratorPattern
{
    // La interfaz del componente base define operaciones que pueden ser modificadas por
    // decoradores.
    public abstract class Component
    {
        public abstract string Operation();
    }
}
