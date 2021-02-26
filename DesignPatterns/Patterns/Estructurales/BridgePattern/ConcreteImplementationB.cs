using System;
namespace DesignPatterns.Patterns.Estructurales.BridgePattern
{
    public class ConcreteImplementationB : IImplementation
    {
        public string OperationImplementation()
        {
            return "ConcreteImplementationB: El resultado en la plataforma B.\n";
        }
    }
}
