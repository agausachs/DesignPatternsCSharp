namespace DesignPatterns.Patterns.Creacionales.AbstractFactoryPattern
{
    internal class ConcreteProductB2 : IAbstractProductB
    {
        public string UsefulFunctionB()
        {
            return "El resultado del producto B2";
        }

        // La variante, Producto B2, solo puede funcionar correctamente con la
        // variante, Producto A2. No obstante, acepta cualquier instancia de
        // AbstractProductA como argumento.
        public string AnorherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();

            return $"El resultado del B2 colaborando con el ({result})";
        }
    }
}