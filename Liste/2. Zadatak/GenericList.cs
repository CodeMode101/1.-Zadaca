using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Zadatak
{
    class GenericList<X> : IGenericList<X>
    {
        private X[] _internalStorage;


        public GenericList()
        {
            _internalStorage = new X[4];
        }

        public GenericList(int initialSize)
        {
            _internalStorage = new X[initialSize];
        }

        public void Add(X item)
        {
            for (int i = 0; i < _internalStorage.Length; ++i)
            {
                if (_internalStorage[i].Equals(default(X)))
                {
                    _internalStorage[i] = item;
                    return;
                }
            }

            X[] temp = new X[_internalStorage.Length];

            for (int i = 0; i < _internalStorage.Length; ++i)
            {
                temp[i] = _internalStorage[i];
            }

            _internalStorage = new X[_internalStorage.Length * 2];

            for (int i = 0; i < temp.Length + 1; ++i)
            {
                if (i == temp.Length)
                    _internalStorage[i] = item;

                _internalStorage[i] = temp[i];
            }
        }

        public bool RemoveAt(int index)
        {
            if (index >= _internalStorage.Length)
                return false;

            for (int i = index; i < _internalStorage.Length; ++i)
            {
                if (i == _internalStorage.Length)
                {
                    _internalStorage[i] = default(X);
                    break;
                }

                _internalStorage[i] = _internalStorage[i + 1];
            }

            return true;
        }

        public bool Remove(X item)
        {
            for (int i = 0; i < _internalStorage.Length; ++i)
            {
                if (_internalStorage[i].Equals(item))
                {
                    RemoveAt(i);
                    return true;
                }
            }

            return false;
        }

        public X GetElement(int index)
        {
            if (index >= _internalStorage.Length)
                throw new IndexOutOfRangeException();

            return _internalStorage[index];
        }

        public int IndexOf(X item)
        {
            for (int i = 0; i < _internalStorage.Length; ++i)
            {
                if (_internalStorage[i].Equals(item))
                    return i;
            }

            return -1;
        }

        public int Count
        {
            get
            {
                for (int i = 0; i < _internalStorage.Length; ++i)
                {
                    if (_internalStorage[i].Equals(default(X)))
                        return i;
                }
                return _internalStorage.Length;
            }
        }

        public void Clear()
        {
            for (int i = 0; i < _internalStorage.Length; ++i)
            {
                _internalStorage[i] = default(X);
            }
        }

        public bool Contains(X item)
        {
            for (int i = 0; i < _internalStorage.Length; ++i)
            {
                if (_internalStorage[i].Equals(item))
                    return true;
            }

            return false;
        }
    }
}

