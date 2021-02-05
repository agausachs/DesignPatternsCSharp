namespace DesignPatterns.Patterns.Creacionales.FactoryMethodPattern
{
    // La clase Creator declara el Factory Method que se supone retornará un objeto
    // de la clase Product. Las subclases de Creator normalmente proveen de la
    // implementación de este método.
    public abstract class Creator
    {
        // Destacar que el Creator también puede proveer alguna implementación por defecto
        // del FactoryMethod.
        public abstract IProduct FactoryMethod();

        // También destacar que, pese a su nombre, la principal responsabilidad del Creator
        // no es crear productos. Normalmente, contiene algo de logica de negocio que reside
        // en los objetos Product, retornados por el FactoryMethod. Las subclases pueden cambiar
        // indirectamente esa logica de negocio sobrecargando el FactoryMethod y retornando un
        // tipo diferente de producto.
        public string SomeOperation()
        {
            // Llamada al Factory Method para crear un objeto Product.
            IProduct product = FactoryMethod();
            // Ahora, usa el Product.
            string result = "Creator: El mismo código de creator ha funcionado con " + product.Operation();

            return result;
        }
    }
}
