using System;
namespace DesignPatterns.Patterns.Comportamiento.MementoPattern
{
    public static class MementoPatternProgram
    {
        public static void Run()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine(" MEMENTO PATTERN ");
            Console.WriteLine("-------------------------");

            // Código cliente.
            Originator originator = new Originator("Super-duper-super-puper-super.");
            Caretaker caretaker = new Caretaker(originator);

            caretaker.Backup();
            originator.DoSomething();

            caretaker.Backup();
            originator.DoSomething();

            caretaker.Backup();
            originator.DoSomething();

            Console.WriteLine("\n");
            caretaker.ShowHistory();

            Console.WriteLine("\nCliente: Ahora, vamos a hacer rollback!\n");
            caretaker.Undo();

            Console.Write("\n");
        }
    }
}
