using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SolidPrinciples.SingleResponsibility
{
    public class GarageStationUtility : IGarageUtility
    {
        public string OpenGate()
        {
            // Abrir el Garaje para el servicio
            return "GarageStationUtility - Abro compuerta";
        }
        public string CloseGate()
        {
            // Cerrar la funcionalidad del Garaje
            return "GarageStationUtility - Cierro compuerta";
        }
    }
}
