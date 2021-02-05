using System;
namespace DesignPatterns.Patterns.Creacionales.AbstractFactoryPattern
{
    // Las fábricas concretas producen una familia de productos que pertenecen a una sola
    // variante. La fábrica garantiza que los productos resultantes son compatibles.
    // Tenga en cuenta que las firmas de los métodos de Concrete Factory devuelven un 
    // producto abstracto, mientras que dentro del método se instancia un producto concreto.
    public class ConcreteFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA1();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB1();
        }
    }
}
