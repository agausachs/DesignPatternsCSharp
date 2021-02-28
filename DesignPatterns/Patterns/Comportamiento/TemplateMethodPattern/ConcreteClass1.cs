using System;
namespace DesignPatterns.Patterns.Comportamiento.TemplateMethodPattern
{
    // Las clases concretas deben implementar todas las operaciones abstractas de la clase base.
    // También pueden anular algunas operaciones con un valor predeterminado de implementación.
    public class ConcreteClass1 : AbstractClass
    {
        protected override void RequiredOperation1()
        {
            Console.WriteLine("ConcreteClass1 dice: Implementada Operación 1.");
        }

        protected override void RequiredOperation2()
        {
            Console.WriteLine("ConcreteClass2 dice: Implementada Operación 2.");
        }
    }
}
