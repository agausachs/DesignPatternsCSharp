using System;

namespace DesignPatterns.Patterns.Estructurales.FacadePattern
{
    // Algunas fachadas puede trabajar con diferentes subsistemas al mismo tiempo.
    public class Subsystem2
    {
        internal string Operation1()
        {
            return "Subsistema2: Prepárate!\n";
        }

        internal string OperationZ()
        {
            return "Subsistema2: Fuego!\n";
        }
    }
}