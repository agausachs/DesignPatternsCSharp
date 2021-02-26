using System;
namespace DesignPatterns.Patterns.Estructurales.ProxyPattern
{
    // El RealSubject contiene algo de lógica empresarial central. Normalmente, RealSubjects
    // son capaces de realizar un trabajo útil que también puede ser muy lento o
    // sensible - p. ej. corrigiendo los datos de entrada. Un proxy puede resolver estos problemas
    // sin ningún cambio en el código de RealSubject.
    public class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("RealSubject: Manipulando Request.");
        }
    }
}
