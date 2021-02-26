namespace DesignPatterns.Patterns.Estructurales.BridgePattern
{
    // La abstracción define la interfaz para la parte de "control" de las dos
    // jerarquías de clases. Mantiene una referencia a un objeto de la
    // jerarquía de implementación y delega todo el trabajo real a este
    // objeto.
    public class Abstraction
    {
        protected IImplementation _implementation;

        public Abstraction(IImplementation implementation)
        {
            _implementation = implementation;
        }

        public virtual string Operation()
        {
            return "Abstract: Base operation with:\n" + _implementation.OperationImplementation();
        }
    }
}
