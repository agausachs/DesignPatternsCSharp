using System;
namespace DesignPatterns.Patterns.Estructurales.AdapterPattern
{
    // El Adaptee (o adaptado) contiene algunos comportamientos útiles, pero su interfaz es
    // incompatible con el código de cliente existente. El Adaptee necesita algo de
    // adaptación antes de que el código del cliente pueda utilizarlo.
    public class Adaptee
    {
        public string GetSpecificRequest()
        {
            return "Request específico.";
        }
    }
}
