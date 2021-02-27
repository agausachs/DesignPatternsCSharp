using System;
namespace DesignPatterns.Patterns.Comportamiento.ChainOfResponsibilityPattern
{
    public class DogHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "Albóndiga")
            {
                return $"Perro: Me comeré la {request}.\n";
            }
            else
            { 
                return base.Handle(request);
            }
        }
    }
}
