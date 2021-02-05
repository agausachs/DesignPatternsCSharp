using System;
namespace DesignPatterns.Patterns.AbstractFactoryPattern
{
    // La interfaz Abstract Factory declara un conjunto de métodos que devuelven
    // diferentes productos abstractos. Estos productos se denominan familia y son
    // relacionado por un tema o concepto de alto nivel. Los productos de una familia son
    // normalmente capaces de colaborar entre ellos. Una familia de productos puede
    // tienen varias variantes, pero los productos de una variante son incompatibles
    // con productos de otro.
    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();
        IAbstractProductB CreateProductB();
    }
}
