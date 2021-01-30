// Este principio sugiere que la clase debería ampliarse fácilmente,
// pero sin ser necesario cambiar sus implementaciones principales.
//
// La aplicación o el software deben ser flexibles para cambiar.
// La forma en que se implementa la gestión de cambios en un sistema
// tiene un impacto significativo en el éxito de esa aplicación / software.
// El OCP establece que los comportamientos del sistema se pueden extender sin
// tener que modificar su implementación existente.
//
// Es decir, las nuevas funciones deben implementarse utilizando el nuevo código,
// pero no cambiando el código existente. El principal beneficio de adherirse a OCP
// es que potencialmente agiliza el mantenimiento del código y reduce el riesgo de
// romper la implementación existente.
using System;

namespace DesignPatterns.SolidPrinciples.OpenClosed
{
    public static class OCPProgram
    {
        public static void Run()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine(" OPEN CLOSED PRINCIPLE ");
            Console.WriteLine("-------------------------");

            Console.WriteLine(" BAD ACCOUNTS ");

            Console.WriteLine(" Bad Regular ");
            BadAccount badAccountOne = new BadAccount();
            badAccountOne.CalcInterest("Regular");

            Console.WriteLine(" Bad Salary ");
            BadAccount badAccountTwo = new BadAccount();
            badAccountTwo.CalcInterest("Salary");

            Console.WriteLine(" Bad Corporate ");
            BadAccount badAccountThree = new BadAccount();
            badAccountThree.CalcInterest("Corporate");


            Console.WriteLine("\n");


            Console.WriteLine(" GOOD ACCOUNTS ");

            Console.WriteLine(" Good Regular ");
            IAccount accountOne = new GoodRegularSavingAccount();
            Console.WriteLine(accountOne.CalcInterest());

            Console.WriteLine(" Good Salary ");
            IAccount accountTwo = new GoodSalarySavingAccount();
            Console.WriteLine(accountTwo.CalcInterest());

            Console.WriteLine(" Good Corporate ");
            IAccount accountThree = new GoodCorporateAccount();
            Console.WriteLine(accountThree.CalcInterest());

            Console.WriteLine("\n");
        }
    }
}
