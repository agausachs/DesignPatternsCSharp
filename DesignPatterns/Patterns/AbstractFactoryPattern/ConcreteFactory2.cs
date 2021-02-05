using System;
namespace DesignPatterns.Patterns.AbstractFactoryPattern
{
    // Cada Concrete Factory tiene una variante de producto correspondiente.
    public class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }
}
