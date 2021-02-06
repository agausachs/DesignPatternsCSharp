using System;
namespace DesignPatterns.Patterns.Estructurales.AdapterPattern
{
    // El Adapter hace compatible la interfície del Adaptee con la interficie del Target
    public class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public string GetRequest()
        {
            return $"Esto es {_adaptee.GetSpecificRequest()}";
        }
    }
}
