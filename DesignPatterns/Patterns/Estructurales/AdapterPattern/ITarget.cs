using System;
namespace DesignPatterns.Patterns.Estructurales.AdapterPattern
{
    // El Target define la interficie especifica de dominio usada por el código cliente.
    public interface ITarget
    {
        string GetRequest();
    }
}
