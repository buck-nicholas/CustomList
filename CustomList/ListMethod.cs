using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class ListMethod<T>
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

        private int Count { get; }

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
    }
}
