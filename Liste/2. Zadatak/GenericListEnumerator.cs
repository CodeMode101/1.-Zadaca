using System.Collections;
using System.Collections.Generic;

namespace _2.Zadatak
{
    public class GenericListEnumerator<T> : IEnumerator<T>
    {
        private IGenericList<T> _collection;
        private int index = 0;

        public GenericListEnumerator(IGenericList<T> collection)
        {
            _collection = collection;
        }

        public bool MoveNext()
        {
            if (index < _collection.Count)
                return true;

            return false;
        }

        public T Current
        {
            get
            {
                if(MoveNext())
                {
                    index++;
                    return _collection.GetElement(index);
                }

                return default(T);
            }
        }

        object IEnumerator.Current
        {
            get{ return Current; }
        }

        public void Dispose()
        {

        }

        public void Reset()
        {

        }
    }
}
