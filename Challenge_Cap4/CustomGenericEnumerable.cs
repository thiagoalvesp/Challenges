using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Challenge_Cap4
{
    class CustomGenericEnumerable<T> : IEnumerable<T>
    {
        T[] array = new T[4];
        int index = -1;

        public CustomGenericEnumerable<T> Add(T o)
        {
            if (++index < array.Length)
            {
                array[index] = o;
            }
            return this;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
