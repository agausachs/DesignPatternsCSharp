using System;
namespace DesignPatterns.Patterns.Comportamiento.VisitorPattern
{
    // Cada Componente concreto debe implementar el método `Accept` de tal manera
    // que llame al método del visitante correspondiente al de la clase del componente.
    public class ConcreteComponentA : IComponent
    {
        // Ten en cuenta que estamos llamando a `VisitConcreteComponentA`, que coincide con el
        // nombre de la clase actual. De esta forma le hacemos saber al visitante la clase del
        // componente con el que trabaja.
        public void Accept(IVisitor visitor)
        {
            visitor.VisitConcreteComponentA(this);
        }

        // Los componentes concretos pueden tener métodos especiales que no existen en
        // su clase base o interfaz. El visitante todavía puede utilizar estos
        // métodos ya que conoce la clase concreta del componente.
        public string ExclusiveMethodOfConcreteComponentA()
        {
            return "A";
        }
    }
}
