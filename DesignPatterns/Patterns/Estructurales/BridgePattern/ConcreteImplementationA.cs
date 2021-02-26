using System;
namespace DesignPatterns.Patterns.Estructurales.BridgePattern
{
    // Cada Implementación Concreta corresponde a una plataforma específica e
    // implementa la interfaz de implementación utilizando la API de esa plataforma.
    public class ConcreteImplementationA : IImplementation
    {
        public string OperationImplementation()
        {
            return "ConcreteImplentationA: El resultado en la plataforma A.\n";
        }
    }
}
