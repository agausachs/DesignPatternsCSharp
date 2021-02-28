using System;
namespace DesignPatterns.Patterns.Comportamiento.TemplateMethodPattern
{
    public class ConcreteClass2 : AbstractClass
    {
        protected override void RequiredOperation1()
        {
            Console.WriteLine("ConcreteClass2 dice: Implementada Operación1.");
        }

        protected override void RequiredOperation2()
        {
            Console.WriteLine("ConcreteClass2 dice: Implementada Operación2.");
        }

        protected override void Hook1()
        {
            Console.WriteLine("ConcreteClass2 dice: Hook1 sobreescrito.");
        }
    }
}
