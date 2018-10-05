using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Challenge_Cap4
{
    public class CustomGenericCollection<T> : ICollection<T>
    {
        T[] _object = new T[4];
        int index = -1;

        public int Count => _object.Length;

        public bool IsReadOnly => false;

        public void Add(T o)
        {
            if (++index < _object.Length)
            {
                _object[index] = o;
            }
        }

        public void Clear()
        {
            _object = new T[4];
        }

        public bool Contains(T item)
        {
            return Array.FindAll(_object, s => s.Equals(item)).Length > 0;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            _object.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _object.Length; i++)
            {
                yield return _object[i];
            }
        }

        public bool Remove(T item)
        {
            int totalBeforeRemove = _object.Length;
            _object = _object.Where(s => !s.Equals(item)).ToArray();
            return totalBeforeRemove > _object.Length;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
