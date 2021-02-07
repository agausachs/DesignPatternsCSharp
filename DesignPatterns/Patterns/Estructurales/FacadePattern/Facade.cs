using System;
namespace DesignPatterns.Patterns.Estructurales.FacadePattern
{
    // La clase Facade proporciona una interfaz simple para la lógica compleja de uno
    // o varios subsistemas. La Fachada delega las solicitudes del cliente a los
    // objetos apropiados dentro del subsistema. La Fachada también es responsable
    // de gestionar el ciclo de vida de los subsistemas. Todo esto protege al cliente de la
    // complejidad no deseada del subsistema.
    public class Facade
    {
        protected Subsystem1 _subsystem1;

        protected Subsystem2 _subsystem2;

        public Facade(Subsystem1 subsystem1, Subsystem2 subsystem2)
        {
            _subsystem1 = subsystem1;
            _subsystem2 = subsystem2;
        }

        // Los métodos de The Facade son atajos convenientes para la sofisticada
        // funcionalidad de los subsistemas. Sin embargo, los clientes solo llegan a una
        // fracción de las capacidades de un subsistema.
        public string Operation()
        {
            string result = "Fachada inicializa subsistemas:\n";
            result += _subsystem1.Operation1();
            result += _subsystem2.Operation1();
            result += "Fachada le pide a los subsistemas que ejecuten la acción:\n";
            result += _subsystem1.OperationN();
            result += _subsystem2.OperationZ();
            return result;
        }
    }
}
