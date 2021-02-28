using System;
namespace DesignPatterns.Patterns.Comportamiento.CommandPattern
{
    // El invocador está asociado con uno o varios componentes. Envía la petición al comando.
    public class Invoker
    {
        private ICommand _onStart;

        private ICommand _onFinish;

        public void SetOnStart(ICommand command)
        {
            _onStart = command;
        }

        public void SetOnFinish(ICommand command)
        {
            _onFinish = command;
        }

        // El Invoker no depende de clases concretas de comandos o receptores.
        // El invocador pasa una solicitud a un receptor indirectamente, ejecutando un
        // comando.
        public void DoSomethingImportant()
        {
            Console.WriteLine("Invoker: Alguien quiere algo antes de que empiece?");

            if (_onStart is ICommand)
            {
                _onStart.Execute();
            }

            Console.WriteLine("Invoker: ... haciendo algo realmente importante ...");

            Console.WriteLine("Invoker: Alguien quiere algo antes de que acabe?");

            if (_onFinish is ICommand)
            {
                _onFinish.Execute();
            }
        }

    }
}
