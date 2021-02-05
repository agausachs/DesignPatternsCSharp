using System;
namespace DesignPatterns.Patterns.Creacionales.PrototypePattern
{
    public static class PrototypePatternProgram
    {
        public static void Run()
        {
            Person p1 = new Person();
            p1.Age = 42;
            p1.BirthDate = Convert.ToDateTime("1978-12-29");
            p1.Name = "Abraham Gausachs";
            p1.IdInfo = new IdInfo(666);

            // Realizar una copia superficial de p1 y asignarlo a p2
            Person p2 = p1.ShallowCopy();
            // Realizar una copia profunda de p1 y asignarlo a p3
            Person p3 = p1.DeepCopy();

            // Mostrar valores de p1, p2 y p3
            Console.WriteLine("Valores originales de p1, p2 y p3:");
            Console.WriteLine(" Valores de instancia p1: ");
            DisplayValues(p1);
            Console.WriteLine(" Valores de instancia p2: ");
            DisplayValues(p2);
            Console.WriteLine(" Valores de instancia p3: ");
            DisplayValues(p3);

            // Cambia los valores de las propiedades de p1 y muestra los valores de p1
            // p2 y p3
            p1.Age = 32;
            p1.BirthDate = Convert.ToDateTime("1900-01-01");
            p1.Name = "Frank";
            p1.IdInfo.IdNumber = 7878;
            Console.WriteLine("\nValores de p1, p2 y p3 después de cambiar p1:");
            Console.WriteLine(" Valores de instancia p1: ");
            DisplayValues(p1);
            Console.WriteLine(" Valores de instancia p2 (los valores de referencia han cambiado): ");
            DisplayValues(p2);
            Console.WriteLine(" Valores de instancia p3 (todo sigue igual): ");
            DisplayValues(p3);
        }

        private static void DisplayValues(Person p)
        {
            Console.WriteLine(" Name: {0:s}, Age: {1:d}, BirthDate: {2:dd/MM/yyyy} ",
                    p.Name, p.Age, p.BirthDate);

            Console.WriteLine(" ID#: {0:d}", p.IdInfo.IdNumber);
        }
    }
}
