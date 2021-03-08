using System;
namespace DesignPatterns.Patterns.Estructurales.CompositePattern
{
    public static class CompositePatternProgram
    {
        public static void Run()
        {

            Console.WriteLine("-------------------------");
            Console.WriteLine(" COMPOSITE PATTERN ");
            Console.WriteLine("-------------------------");

            Client client = new Client();

            // De esta manera el código cliente puede soportar tanto los
            // componentes hojas simples...
            Leaf leaf = new Leaf();
            Console.WriteLine("Cliente: Recibí un componente simple:");
            client.ClientCode(leaf);

            // ...como los compuestos complejos.
            Composite tree = new Composite();
            Composite branch1 = new Composite();
            branch1.Add(new Leaf());
            branch1.Add(new Leaf());
            Composite branch2 = new Composite();
            branch2.Add(new Leaf());
            tree.Add(branch1);
            tree.Add(branch2);
            Console.WriteLine("Cliente: Ahora tengo un árbol compuesto:");
            client.ClientCode(tree);

            Console.WriteLine("Cliente: No necesito comprobar las clases componentes aunque este gestionando un árbol:\n");
            client.ClientCode2(tree, leaf);

            Console.WriteLine("\n");
        }
    }
}
