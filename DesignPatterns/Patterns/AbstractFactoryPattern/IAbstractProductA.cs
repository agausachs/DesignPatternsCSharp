namespace DesignPatterns.Patterns.AbstractFactoryPattern
{
    // Cada producto distinto de una familia de productos debe tener una interfaz básica.
    // Todas las variantes del producto deben implementar esta interfaz.
    public interface IAbstractProductA
    {
        string UsefulFunctionA();
    }
}