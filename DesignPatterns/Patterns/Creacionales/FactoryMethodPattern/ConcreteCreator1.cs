namespace DesignPatterns.Patterns.Creacionales.FactoryMethodPattern
{
    // El Creator concreto sobrecarga el Factory Method para cambiar el tipo de Product retornado
    public class ConcreteCreator1 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }
}
