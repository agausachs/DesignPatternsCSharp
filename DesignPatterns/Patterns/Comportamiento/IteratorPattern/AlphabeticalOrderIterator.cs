namespace DesignPatterns.Patterns.Comportamiento.IteratorPattern
{
    // Los iteradores concretos implementan varios algoritmos de recorrido. Estas clases
    // almacenan la posición transversal actual en todo momento.
    public class AlphabeticalOrderIterator : Iterator
    {
        private WordsCollection _collection;

        // Almacena la posición transversal actual. Un iterador puede tener muchos
        // otros campos para almacenar el estado de iteración, especialmente cuando
        // se supone que debe funcionar con un tipo particular de colección.
        private int _position = -1;

        private bool _reverse = false;

        public AlphabeticalOrderIterator(WordsCollection collection, bool reverse)
        {
            _collection = collection;
            _reverse = reverse;

            if (reverse)
            {
                _position = collection.GetItems().Count;
            }

        }

        public override object Current()
        {
            return _collection.GetItems()[_position];
        }

        public override int Key()
        {
            return _position;
        }

        public override bool MoveNext()
        {
            int updatedPosition = _position + (_reverse ? -1 : 1);

            if (updatedPosition >= 0 && updatedPosition < _collection.GetItems().Count)
            {
                _position = updatedPosition;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Reset()
        {
            _position = _reverse ? _collection.GetItems().Count - 1 : 0;
        }
    }
}
