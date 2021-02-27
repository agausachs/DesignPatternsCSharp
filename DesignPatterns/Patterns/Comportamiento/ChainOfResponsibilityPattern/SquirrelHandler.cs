using System;
namespace DesignPatterns.Patterns.Comportamiento.ChainOfResponsibilityPattern
{
    public class SquirrelHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "Nuez")
            {
                return $"Ardilla: Me comeré la {request}.\n";
            }
            else
            {
                return base.Handle(request);
            }
            
        }
    }
}
