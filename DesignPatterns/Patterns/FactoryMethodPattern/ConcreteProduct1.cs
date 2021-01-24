namespace DesignPatterns.Patterns.FactoryMethodPattern
{
    // Products concretos proveen varias implementaciones del interface de Product
    public class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "{Resultat de ConcreteProduct1}";
        }
    }
}