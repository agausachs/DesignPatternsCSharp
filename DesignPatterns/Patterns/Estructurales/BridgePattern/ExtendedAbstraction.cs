using System;
namespace DesignPatterns.Patterns.Estructurales.BridgePattern
{
    // Puedes extender la abstracción sin cambiar las clases de implementación
    public class ExtendedAbstraction : Abstraction
    {
        public ExtendedAbstraction(IImplementation implementation): base(implementation)
        {
        }

        public override string Operation()
        {
            return "ExtendedAbstraction: Extended operation with:\" + " +
                base._implementation.OperationImplementation();
        }
    }
}
