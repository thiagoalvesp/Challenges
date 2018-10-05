using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenge_Cap4
{
    class CustomGenericList<T> : IList<T>
    {
        T[] array = new T[4];
        int index = -1;

        public T this[int index] { get => array[index] ; set => array[index] = value; }

        public int Count => array.Length;

        public bool IsReadOnly => false;

        public CustomGenericList<T> Add(T item)
        {
            if (++index < array.Length)
            {
                array[index] = item;
            }
            return this;
        }

        public void Clear()
        {
            array = new T[4];
        }

        public bool Contains(T item)
        {
            return Array.FindAll(array, s => s.Equals(item)).Length > 0;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return array[i];
            }
        }

        public int IndexOf(T item)
        {
           return array.OfType<T>().ToList().IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        void ICollection<T>.Add(T item)
        {
            this.Add(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
