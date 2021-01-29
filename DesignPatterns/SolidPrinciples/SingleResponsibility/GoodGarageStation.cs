using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SolidPrinciples.SingleResponsibility
{
    public class GoodGarageStation
    {
        private IGarageUtility _garageUtility;

        public GoodGarageStation(IGarageUtility garageUtility)
        {
            _garageUtility = garageUtility;
        }

        public string OpenForService()
        {
            return _garageUtility.OpenGate();
        }

        public string DoService()
        {
            // Mirar si la estación de servicio está abierta y entonces
            // acabar el servicio al vehículo
            return "Good - Hago Servicio";
        }

        public string CloseGarage()
        {
            return _garageUtility.CloseGate();
        }
    }
}
