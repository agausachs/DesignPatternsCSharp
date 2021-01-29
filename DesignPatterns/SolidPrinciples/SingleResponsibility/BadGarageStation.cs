using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SolidPrinciples.SingleResponsibility
{
    public class BadGarageStation
    {
        public string DoOpenGate()
        {
            // Funcionalidad de abrir la compuerta
            return "Bad - Abro Compuerta";
        }

        public string PerformService()
        {
            // Mirar si el garaje está abierto
            // Acabar el servicio al vehiculo
            return "Bad - Hago Servicio";
        }

        public string DoCloseGate()
        {
            // Funcionalidad de cerrar la compuerta
            return "Bad - Cierro Compuerta";
        }

    }
}
