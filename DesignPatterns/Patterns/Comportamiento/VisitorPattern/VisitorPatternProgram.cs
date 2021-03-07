using System;
using System.Collections.Generic;

namespace DesignPatterns.Patterns.Comportamiento.VisitorPattern
{
    public static class VisitorPatternProgram
    {
        public static void Run()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine(" VISITOR PATTERN ");
            Console.WriteLine("-------------------------");

            List<IComponent> components = new List<IComponent>
            {
                new ConcreteComponentA(),
                new ConcreteComponentB()
            };

            Console.WriteLine("El código cliente funciona con todos los visitors via la interfície base Visitor");

            ConcreteVisitor1 visitor1 = new ConcreteVisitor1();
            Client.ClientCode(components, visitor1);

            Console.WriteLine();

            Console.WriteLine("Este permite al mismo código cliente funcionar con diferentes tipos de visitors.");

            ConcreteVisitor2 visitor2 = new ConcreteVisitor2();
            Client.ClientCode(components, visitor2);

            Console.WriteLine("\n");
        }
    }
}
