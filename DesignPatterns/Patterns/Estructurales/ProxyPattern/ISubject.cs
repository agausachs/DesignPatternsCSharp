namespace DesignPatterns.Patterns.Estructurales.ProxyPattern
{
    // La interfaz del sujeto declara operaciones comunes para RealSubject y
    // el Proxy. Siempre que el cliente trabaje con RealSubject usando este
    // interfaz, podrá pasarle un proxy en lugar de un asunto real.
    public interface ISubject
    {
        void Request();
    }
}
