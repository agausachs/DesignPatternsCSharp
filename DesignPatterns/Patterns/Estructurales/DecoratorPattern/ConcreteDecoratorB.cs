namespace DesignPatterns.Patterns.Estructurales.DecoratorPattern
{
    // Los decoradores pueden ejecutar su comportamiento antes o después de la llamada a
    // un objeto envuelto.
    public class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(Component comp) : base(comp)
        {
        }

        public override string Operation()
        {
            return $"ConcreteDecoratorB({base.Operation()})";
        }
    }
}
