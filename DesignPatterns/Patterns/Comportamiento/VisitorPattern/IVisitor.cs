namespace DesignPatterns.Patterns.Comportamiento.VisitorPattern
{
    // La interfaz Visitor declara un conjunto de métodos de visita que corresponden
    // a las clases de los componentes. La firma de un método de visita permite al
    // visitante identificar la clase exacta del componente con el que está tratando.
    public interface IVisitor
    {
        void VisitConcreteComponentA(ConcreteComponentA concreteComponentA);

        void VisitConcreteComponentB(ConcreteComponentB concreteComponentB);
    }
}