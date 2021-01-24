namespace DesignPatterns.Patterns.FactoryMethodPattern
{
    // La interface de Product declara las operaciones que todos los products concretos
    // deben implementar.
    public interface IProduct
    {
        string Operation();
    }
}