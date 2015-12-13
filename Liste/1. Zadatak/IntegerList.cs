using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Zadatak
{
    public class IntegerList : IIntegerList
    {
        private int[] _internalStorage;


        public IntegerList()
        {
            _internalStorage = new int[4];
        }

        public IntegerList(int initialSize)
        {
            _internalStorage = new int[initialSize];
        }

        public void Add(int item)
        {
            for (int i = 0; i < _internalStorage.Length; ++i)
            {
                if (_internalStorage[i] == 0)
                {
                    _internalStorage[i] = item;
                    return;
                }
            }

            int[] temp = new int[_internalStorage.Length];

            for(int i = 0; i < _internalStorage.Length; ++i)
            {
                temp[i] = _internalStorage[i];
            }

            _internalStorage = new int[_internalStorage.Length * 2];

            for(int i = 0; i < temp.Length + 1; ++i)
            {
                if(i == temp.Length)
                    _internalStorage[i] = item;

                _internalStorage[i] = temp[i];
            }
        }

        public bool RemoveAt(int index)
        {
            if (index >= _internalStorage.Length)
                return false;

            for(int i = index; i < _internalStorage.Length; ++i)
            {
                if(i == _internalStorage.Length)
                {
                    _internalStorage[i] = 0;
                    break;
                }

                _internalStorage[i] = _internalStorage[i + 1];
            }

            return true;
        }

        public bool Remove(int item)
        {
            for(int i = 0; i < _internalStorage.Length; ++i)
            {
                if (_internalStorage[i] == item)
                {
                    RemoveAt(i);
                    return true;
                }
            }

            return false;
        }

        public int GetElement(int index)
        {
            if (index >= _internalStorage.Length)
                throw new IndexOutOfRangeException();

            return _internalStorage[index];
        }

        public int IndexOf(int item)
        {
            for(int i = 0; i < _internalStorage.Length; ++ i)
            {
                if (_internalStorage[i] == item)
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
                    if (_internalStorage[i] == 0)
                        return i;
                }
                return _internalStorage.Length;
            }
        }

        public void Clear()
        {
            for(int i = 0; i < _internalStorage.Length; ++i)
            {
                _internalStorage[i] = 0;
            }
        }

        public bool Contains(int item)
        {
            for(int i = 0; i < _internalStorage.Length; ++i)
            {
                if (_internalStorage[i] == item)
                    return true;
            }

            return false;
        }
    }
}
