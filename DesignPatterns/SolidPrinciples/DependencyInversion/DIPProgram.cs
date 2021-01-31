using System;
namespace DesignPatterns.SolidPrinciples.DependencyInversion
{
    // El principio dice que los módulos de alto nivel deben depender de la abstracción,
    // no de los detalles, de los módulos de bajo nivel. En palabras simples, el principio
    // dice que no debe haber un acoplamiento estrecho entre los componentes del software y,
    // para evitarlo, los componentes deben depender de la abstracción.
    // 
    // Los términos inyección de dependencia(DI) e inversión de control(IoC) se utilizan
    // generalmente de forma intercambiable para expresar el mismo patrón de diseño.
    // La inversión de control (IoC) es una técnica para implementar el principio de
    // inversión de dependencia en C #. La inversión del control se puede implementar
    // utilizando una clase abstracta o una interfaz. La regla es que las entidades de
    // nivel inferior deben unir el contrato a una sola interfaz y las entidades de
    // nivel superior utilizarán solo entidades que están implementando la interfaz.
    // Esta técnica elimina la dependencia entre las entidades. 
    public static class DIPProgram
    {
        public static void Run()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine(" DEPENDENCY INVERSION PRINCIPLE ");
            Console.WriteLine("-------------------------");

            Console.WriteLine("\n");

            IGoodAutomobile automobile = new GoodJeep();
            //IGoodAutomobile automobile = new GoodSUV();

            GoodAutomobileController automobileController = new GoodAutomobileController(automobile);

            automobileController.Ignition();

            automobileController.Stop();

            Console.WriteLine("\n");
        }
    }
}
