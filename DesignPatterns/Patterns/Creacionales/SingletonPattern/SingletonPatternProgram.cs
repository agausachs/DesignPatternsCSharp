using System;
using System.Threading;

namespace DesignPatterns.Patterns.Creacionales.SingletonPattern
{
    public static class SingletonPatternProgram
    {
        public static void Run()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine(" SINGLETON PATTERN ");
            Console.WriteLine("-------------------------");

            Console.WriteLine(" SINGLETON INGENUO ");
            SingletonIngenuo s1 = SingletonIngenuo.GetInstancia();
            SingletonIngenuo s2 = SingletonIngenuo.GetInstancia();

            if (s1 == s2)
            {
                Console.WriteLine("El singleton funciona, ambas variables contienen la misma instancia.");
            }
            else
            {
                Console.WriteLine("El singleton falló, las variables contienen instancias diferentes.");
            }

            Console.WriteLine("\n");


            Console.WriteLine(" SINGLETON THREAD SAFE ");

            Console.WriteLine(
                "{0}\n{1}\n\n{2}\n",
                "Si ves el mismo valor, entonces es que el Singleton ha sido reutilizado (bien!)",
                "Si ves valores distintos, entonces es que se han creado 2 Singletons (mal!)",
                "RESULTADO:"
                );

            Thread proceso1 = new Thread(() =>
            {
                TestSingleton("FOO");
            });

            Thread proceso2 = new Thread(() =>
            {
                TestSingleton("BAR");
            });

            proceso1.Start();
            proceso2.Start();

            proceso1.Join();
            proceso2.Join();

            Console.Write("\n");
        }

        private static void TestSingleton(string value)
        {
            SingletonThreadSafe singleton = SingletonThreadSafe.GetInstancia(value);
            Console.WriteLine(singleton.Value); 
        }
    }
}
