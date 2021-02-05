namespace DesignPatterns.Patterns.Creacionales.AbstractFactoryPattern
{
    // Los productos concretos son creados por las correspondientes fábricas concretas.
    internal class ConcreteProductB1 : IAbstractProductB
    {
        public string UsefulFunctionB()
        {
            return "El resultado del producto B1";
        }

        // La variante, Producto B1, solo puede funcionar correctamente con la
        // variante, Producto A1. No obstante, acepta cualquier instancia de
        // AbstractProductA como argumento.
        public string AnorherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();

            return $"El resultado de el B1 colaborando con el ({result})";
        }
    }
}