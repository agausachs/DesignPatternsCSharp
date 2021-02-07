using System;

namespace DesignPatterns.Patterns.Estructurales.FacadePattern
{
    // El Subsistema puede aceptar solicitudes tanto de la fachada como del cliente
    // directamente. En cualquier caso, para el Subsistema, la Fachada es otro
    // cliente y no es parte del subsistema.
    public class Subsystem1
    {
        internal string Operation1()
        {
            return "Subsistema1: Preparado!\n";
        }

        internal string OperationN()
        {
            return "Subsistema1: Adelante!\n";
        }
    }
}