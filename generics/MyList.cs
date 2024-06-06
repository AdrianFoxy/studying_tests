using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    public class MyList<T>
    {
        private T[] _array = Array.Empty<T>();

        public T this[int index]
        {
            get
            {
                return _array[index];
            }
            set
            {
                _array[index] = value; 
            }
        }

        public int Count { get { return _array.Length; } }

        public void Add(T value)
        {
            var newArray = new T[_array.Length + 1];
            for(int i = 0; i< _array.Length; i++)
            {
                newArray[i] = _array[i];
            }
            newArray[_array.Length] = value;

            _array = newArray;
        }
    }
}
