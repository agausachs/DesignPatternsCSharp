using System;
namespace DesignPatterns.Patterns.Comportamiento.VisitorPattern
{
    // Los visitantes concretos implementan varias versiones del mismo algoritmo, que
    // puede trabajar con todas las clases de componentes concretos.
    //
    // Se puede experimentar el mayor beneficio del patrón de visitante cuando se usa
    // con una estructura de objeto compleja, como un árbol compuesto. En este
    // caso, puede ser útil almacenar algún estado intermedio del
    // algoritmo mientras se ejecutan los métodos del visitante sobre varios objetos de la
    // estructura.
    public class ConcreteVisitor1 : IVisitor
    {
        public void VisitConcreteComponentA(ConcreteComponentA element)
        {
            Console.WriteLine(element.ExclusiveMethodOfConcreteComponentA() + " + ConcreteVisitor1");
        }

        public void VisitConcreteComponentB(ConcreteComponentB element)
        {
            Console.WriteLine(element.SpecialMethodOfConcreteComponentB() + " + ConcreteVisitor1");
        }
    }
}
