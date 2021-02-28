using System;
namespace DesignPatterns.Patterns.Comportamiento.TemplateMethodPattern
{
    // La clase abstracta define un método de plantilla que contiene un esqueleto de
    // algún algoritmo, compuesto por llamadas a (generalmente) operaciones primitivas abstractas.
    //
    // Las subclases concretas deben implementar estas operaciones, pero dejar el
    // método de plantilla en sí mismo intacto.
    public abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            BaseOperation1();
            RequiredOperation1();
            BaseOperation2();
            Hook1();
            RequiredOperation2();
            BaseOperation3();
            Hook2();
        }

        // Estas operaciones ya tienen implementaciones.
        protected void BaseOperation1()
        {
            Console.WriteLine("AbstractClass dice: Estoy haciendo la mayor parte de mi trabajo.");
        }

        protected void BaseOperation2()
        {
            Console.WriteLine("AbstractClass dice: Pero permito a las subclases sobreescribir algunas operaciones.");
        }

        protected void BaseOperation3()
        {
            Console.WriteLine("AbstractClass dice: Pero estoy haciendo la mayor parte de mi trabajo de todas maneras.");
        }

        // Estas operaciones deben ser implementadas en las subclases.
        protected abstract void RequiredOperation1();

        protected abstract void RequiredOperation2();

        // Estos son "ganchos". Las subclases pueden sobreescribirlas, pero no es
        // obligatorio ya que los ganchos ya tienen implementaciones predeterminadas (pero están vacías).
        // Los ganchos proporcionan puntos de extensión adicionales en algunos
        // lugares cruciales del algoritmo.
        protected virtual void Hook1() { }

        protected virtual void Hook2() { }
    }
}
