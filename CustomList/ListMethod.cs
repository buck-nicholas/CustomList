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
        public int Count
        {
            get
            {
                return count;
            }
        }
        public void Add(T item)
        {
            T[] largerArray = new T[capacity + 1];
            for(int i = 0; i < count; i++)
            {
                largerArray[i] = newArray[i];
            }
            largerArray[count] = item;
            count++;
            newArray = largerArray;
        }
        public void RemoveAt(int index)
        {
            try
            {
                T[] reducedArray = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    if (i < index && )
                    {
                        reducedArray[i] = newArray[i];
                    }
                    else if (i > index)
                    {
                        reducedArray[i - 1] = newArray[i];
                    }
                }
                newArray = reducedArray;
                count--;
            }
            catch
            {
                System.IndexOutOfRangeException indexOutOfRange = new System.IndexOutOfRangeException("Index cannot be out of range");
                throw indexOutOfRange;
            }
        }
        public void Remove(T value)
        {
            T[] reducedArray = new T[capacity];
            bool isFound = false;
            for (int i = 0; i < count; i++)
            {
                if (!value.Equals(newArray[i]) && !isFound)
                {
                    reducedArray[i] = newArray[i];
                }
                if ((!value.Equals(newArray[i]) && isFound) || (value.Equals(newArray[i]) && isFound))
                {
                    reducedArray[i - 1] = newArray[i];
                }
                if (value.Equals(newArray[i]) && !isFound)
                {
                    isFound = true;
                    count--;
                }
            }
            newArray = reducedArray;
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
