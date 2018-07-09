using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CustomList
{
    public class ListMethod<T> : IEnumerable<T>
    {
        public T[] newArray;
        private int capacity;
        private int count;
        public ListMethod()
        {
            capacity = 5;
            count = 0;
            newArray = new T[capacity];
        }
        public T this[int index] // Indexer
        {
            get
            {
                return newArray[index];
            }
            set
            {
                newArray[index] = value;
            }
        }
        private int Capacity { get; }
        private int Count
        {
            get
            {
                return newArray.Count();
            }
        }
        public void Add(T item)
        {
            if (count >= capacity)
            {
                capacity++;
                Array.Resize(ref newArray, capacity);
            }
            newArray[count] = item;
            count++;
        }
        public void Remove(int index)
        {
            try
            {
                T[] reducedArray = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    if (i < index)
                    {
                        reducedArray[i] = newArray[i];
                    }
                    else if (i > index)
                    {
                        reducedArray[i - 1] = newArray[i];
                    }
                }
                newArray = reducedArray;
            }
            catch
            {
                System.IndexOutOfRangeException indexOutOfRange = new System.IndexOutOfRangeException("Index cannot be out of range");
                throw indexOutOfRange;
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            for(int index = 0; index < newArray.Length; index++)
            {
                yield return newArray[index];
            }
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
