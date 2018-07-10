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
        private int count;
        private int capacity;
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
        public int Count
        {
            get
            {
                return count;
            }
        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
        }
        public void Add(T item)
        {
            if (count + 1 > Math.Round(capacity * .8))
            {
                int capacityIncrement = Convert.ToInt32(Math.Round(capacity * .8));
                capacity += capacityIncrement;
                T[] largerArray = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    largerArray[i] = newArray[i];
                }
                newArray = largerArray;
            }
            newArray[count] = item;
            count++;
        }
        public bool RemoveAt(int index)
        {
            bool removeAt = false;
            try
            {
                if (index >= 0 && index < count)
                {
                    T[] reducedArray = new T[count];
                    int reducedCount = 0;
                    for (int i = 0; i < count; i++)
                    {
                        if (i < index)
                        {
                            reducedArray[i] = newArray[i];
                            reducedCount++;
                        }
                        else if (i > index)
                        {
                            reducedArray[i - 1] = newArray[i];
                            reducedCount++;
                        }
                    }
                    if (count == reducedCount + 1)
                    {
                        removeAt = true;
                    }
                    newArray = reducedArray;
                    count--;
                }
            }
            catch
            {
                System.IndexOutOfRangeException indexOutOfRange = new System.IndexOutOfRangeException("Index cannot be out of range");
                throw indexOutOfRange;
            }
            return removeAt;
        }
        public bool Remove(T value)
        {
            T[] reducedArray = new T[count];
            int reducedCount = 0;
            bool isFound = false;
            for (int i = 0; i < count; i++)
            {
                if (!value.Equals(newArray[i]) && !isFound)
                {
                    reducedArray[i] = newArray[i];
                    reducedCount++;
                }
                if ((!value.Equals(newArray[i]) && isFound) || (value.Equals(newArray[i]) && isFound))
                {
                    reducedArray[i - 1] = newArray[i];
                    reducedCount++;
                }
                if (value.Equals(newArray[i]) && !isFound)
                {
                    isFound = true;
                    count--;
                }
            }
            newArray = reducedArray;
            return isFound;
        }
        public IEnumerator<T> GetEnumerator()
        {
            for(int index = 0; index < Count; index++)
            {
                yield return newArray[index];
            }
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        public static ListMethod<T> operator+ (ListMethod<T> list1, ListMethod<T> list2)
        {
            ListMethod<T> combinedList = new ListMethod<T>();
            for (int i = 0; i < list1.Count; i++)
            {
                combinedList.Add(list1[i]);
            }
            for (int i = 0; i < list2.Count; i++)
            {
                combinedList.Add(list2[i]);
            }
            return combinedList;
        }
        public static ListMethod<T> operator- (ListMethod<T> list1, ListMethod<T> list2)
        {
            ListMethod<T> subtractedList = new ListMethod<T>();
            bool isFound;
            foreach(T item in list1)
            {
                isFound = false;
                for(int i = 0; i < list2.Count; i++)
                {
                    if (item.Equals(list2[i]))
                    {
                        isFound = true;
                    }
                }
                if (!isFound)
                {
                    subtractedList.Add(item);
                }
            }
            return subtractedList;
        }
        public override string ToString()
        {
            if (newArray[0].GetType().IsArray)
            {
                System.FormatException listTypeIsArray = new System.FormatException("Cannot implicitly convert array to string");
                throw listTypeIsArray;
            }
            try
            {
                StringBuilder BobTheBuilder = new StringBuilder();
                foreach (T item in newArray)
                {
                    BobTheBuilder.Append(item).Append(",");
                }
                string newString = BobTheBuilder.ToString().Remove(BobTheBuilder.Length - 1, 1);
                return newString;
            }
            catch
            {
                System.FormatException emptyArray = new System.FormatException("Cannot convert empty list to string");
                throw emptyArray;
            }
        }
        public ListMethod<T> Zip(ListMethod<T> listTwo)
        {
            ListMethod<T> newList = new ListMethod<T>();
            int i = 0;
            do
            {
                if (i < count)
                {
                    newList.Add(newArray[i]);
                }
                if (i < listTwo.Count)
                {
                    newList.Add(listTwo[i]);
                }
                i++;
            } while (count > i || listTwo.Count > i);
            return newList;
        }
    }
}
