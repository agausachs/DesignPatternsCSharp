namespace DesignPatterns.Patterns.AbstractFactoryPattern
{
    // Los productos concretos son creados por las correspondientes fábricas concretas.
    internal class ConcreteProductA1 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "El resultado del producto A1";
        }
    }
}