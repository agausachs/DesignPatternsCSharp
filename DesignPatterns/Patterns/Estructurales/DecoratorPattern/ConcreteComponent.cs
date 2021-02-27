namespace DesignPatterns.Patterns.Estructurales.DecoratorPattern
{
    // Los componentes concretos proporcionan implementaciones predeterminadas de las operaciones.
    // Puede haber varias variaciones de estas clases.
    public class ConcreteComponent : Component
    {
        public override string Operation()
        {
            return "ConcreteComponent";
        }
    }
}
