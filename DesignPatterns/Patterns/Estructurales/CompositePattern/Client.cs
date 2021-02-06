using System;
namespace DesignPatterns.Patterns.Estructurales.CompositePattern
{
    public class Client
    {
        public void ClientCode(Component hoja)
        {
            Console.WriteLine($"RESULT: {hoja.Operation()}\n");
        }

        public void ClientCode2(Component component1, Component component2)
        {
            if (component1.IsComposite())
            {
                component1.Add(component2);
            }

            Console.WriteLine($"RESULT: {component1.Operation()}");
        }
    }
}
