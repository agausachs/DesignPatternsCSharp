namespace DesignPatterns.Patterns.AbstractFactoryPattern
{
    // Aquí está la interfaz base de otro producto. Todos los productos pueden
    // interactuar entre sí, pero la interacción adecuada solo es posible entre
    // productos de la misma variante concreta.
    public interface IAbstractProductB
    {
        // El producto B es capaz de hacer sus propias cosas
        string UsefulFunctionB();

        //... pero también puede colaborar con el ProductoA
        //
        // La Factory Abstracta asegura que todos los productos que crea sean del
        // la misma variante, y por tanto, compatibles.
        string AnorherUsefulFunctionB(IAbstractProductA collaborator);
    }
}