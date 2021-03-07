namespace DesignPatterns.Patterns.Comportamiento.VisitorPattern
{
    // La interfaz del componente declara un método `accept` que debe tomar el
    // interfaz del visitante base como argumento.
    public interface IComponent
    {
        void Accept(IVisitor visitor);
    }
}
