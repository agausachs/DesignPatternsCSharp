using System;

namespace DesignPatterns.Patterns.Comportamiento.MementoPattern
{
    // La interfaz de Memento proporciona una forma de recuperar los metadatos del memento,
    // como la fecha de creación o el nombre. Sin embargo, no expone el
    // estado del originador.
    public interface IMemento
    {
        string GetName();

        string GetState();

        DateTime GetDate();
    }
}