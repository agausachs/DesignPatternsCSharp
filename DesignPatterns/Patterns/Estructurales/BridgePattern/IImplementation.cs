namespace DesignPatterns.Patterns.Estructurales.BridgePattern
{
    // La implementación define la interfaz para todas las clases de implementación.
    // No tiene que coincidir con la interfaz de Abstraction. De hecho, las dos
    // interfaces pueden ser completamente diferentes. Normalmente la implementación
    // de la interfaz proporciona solo operaciones primitivas, mientras que la abstracción
    // define operaciones de nivel superior basadas en esas primitivas.
    public interface IImplementation
    {
        string OperationImplementation();
    }
}