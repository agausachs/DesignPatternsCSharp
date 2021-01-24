using System;
namespace DesignPatterns.Patterns.BuilderPattern
{
    // El interface Builder especifica metodos para crear diferentes partes
    // de los objetos Producto.
    public interface IBuilder
    {
        void BuildPartA();

        void BuildPartB();

        void BuildPartC();
    }
}
