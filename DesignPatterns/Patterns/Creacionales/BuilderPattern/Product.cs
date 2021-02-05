using System.Collections.Generic;

namespace DesignPatterns.Patterns.Creacionales.BuilderPattern
{
    // Tiene sentido usar el patrón Builder solo cuando tus productos
    // son bastante complejos y requieren de una configuración extensiva.
    //
    // A diferencia de otro patrones creacionales, distintos builder concretos
    // pueden producir productos no relacionados. En otras palabras, los resultados
    // de varios builders pueden no seguir siempre el mismo interface.
    public class Product
    {
        private List<object> _parts = new List<object>();

        public void Add(string part)
        {
            this._parts.Add(part);
        }

        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < this._parts.Count; i++)
            {
                str += this._parts[i] + ", ";
            }

            str = str.Remove(str.Length - 2); // borrando la ultima ",c"

            return "Product parts: " + str + "\n";
        }
    }
}