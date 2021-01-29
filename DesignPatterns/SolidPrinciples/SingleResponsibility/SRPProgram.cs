using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SolidPrinciples.SingleResponsibility
{
    public static class SRPProgram
    {
        public static void Run()
        {
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

        }

    }
}
