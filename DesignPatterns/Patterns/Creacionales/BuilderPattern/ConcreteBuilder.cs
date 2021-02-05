using System;
namespace DesignPatterns.Patterns.Creacionales.BuilderPattern
{
    public class ConcreteBuilder: IBuilder
    {
        private Product _product = new Product();

        // Una instancia nueva del builder debe contener un objeto Product vacío,
        // que será usado en una assembly relacionada.
        public ConcreteBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._product = new Product();
        }

        // Todos los pasos de producción trabajan con la misma instancia de Producto.
        public void BuildPartA()
        {
            this._product.Add("PartA1");
        }

        public void BuildPartB()
        {
            this._product.Add("PartB1");
        }

        public void BuildPartC()
        {
            this._product.Add("PartC1");
        }


        // A los Builders concretos se les supone que proveeran de sus propios
        // metodos para devolver resultados. Esto se debe a que varios tipos de
        // constructores pueden crear productos totalmente diferentes que no siguen
        // la misma interface. Por tanto, esos metodos no pueden ser declarados en
        // la interface base del Builder.
        //
        // Normalmente, después de retornar el resultado final al cliente, se espera que
        // una instancia de builder este preparada para empezar a producir otro producto.
        // Es por eso que es una practica habitual llamar al método resete al final del
        // cuerpo del metodo GetProduct. Aún así, este comportamiento no es obligatorio
        // así que puedes hacer que tus constructores esperen a una llamada explicita de
        // reset del cliente antes de despachar el resultado previo. 
        public Product GetProduct()
        {
            Product result = this._product;

            this.Reset();

            return result;
        }
    }
}
