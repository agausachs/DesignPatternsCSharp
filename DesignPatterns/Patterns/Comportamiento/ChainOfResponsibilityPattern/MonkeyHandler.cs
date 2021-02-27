using System;
namespace DesignPatterns.Patterns.Comportamiento.ChainOfResponsibilityPattern
{
    public class MonkeyHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "Banana")
            {
                return $"Mono: Me comeré la {request}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
