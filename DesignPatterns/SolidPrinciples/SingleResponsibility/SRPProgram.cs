using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SolidPrinciples.SingleResponsibility
{
    public static class SRPProgram
    {
        // En términos simples, un módulo o clase debe tener una pequeña parte de responsabilidad en toda la aplicación.
        // O como dice, una clase / módulo no debería tener más de una razón para cambiar.

        // Si una clase tiene una sola responsabilidad, es probable que sea muy sólida. Es fácil verificar su funcionamiento 
        // según la lógica definida.Y es fácil cambiar de clase, ya que tiene una única responsabilidad.

        // El principio de responsabilidad única proporciona otro beneficio. Las clases, los componentes de software y 
        // los módulos que tienen una sola responsabilidad son mucho más fáciles de explicar, implementar y comprender que los que dan solución a todo.
        public static void Run()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine(" SINGLE RESPONSIBILITY PRINCIPLE ");
            Console.WriteLine("-------------------------");

            Console.WriteLine(" BAD GARAGE ");
            BadGarageStation badGarage = new BadGarageStation();
            Console.WriteLine(badGarage.DoOpenGate());
            Console.WriteLine(badGarage.PerformService());
            Console.WriteLine(badGarage.DoCloseGate());

            Console.WriteLine("\n");

            Console.WriteLine(" GOOD GARAGE ");
            IGarageUtility garageStationUtility = new GarageStationUtility();
            GoodGarageStation goodGarage = new GoodGarageStation(garageStationUtility);
            Console.WriteLine(goodGarage.OpenForService());
            Console.WriteLine(goodGarage.DoService());
            Console.WriteLine(goodGarage.CloseGarage());

            Console.WriteLine("\n");

        }

    }
}
