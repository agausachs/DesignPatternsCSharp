using System;
namespace DesignPatterns.Patterns.Creacionales.BuilderPattern
{
    // El Director solo es responsable de ejecutar los pasos de construcción en una
    // secuencia determinada. Es útil cuando se producen productos acorde a un orden
    // especifico o a una configuración determinada. Hablando estrictamente, la clase
    // Director es opcional, dado que incluso el cliente puede controlar a los builders
    // directamente.
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Buider {
            set{ _builder = value; }
        }

        // El Director puede construir varias variaciones del producto usando los mismos
        // pasos de construcción.
        public void BuildMinimalViableProduct()
        {
            this._builder.BuildPartA();
        }

        public void BuildFullFeaturedProduct()
        {
            this._builder.BuildPartA();
            this._builder.BuildPartB();
            this._builder.BuildPartC();
        }
    }
}
