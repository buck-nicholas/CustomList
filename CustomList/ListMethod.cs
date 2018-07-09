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
        public ListMethod()
        {
            //capacity = 5;
            count = 0;
            newArray = new T[count];
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
        public void Add(T item)
        {
            T[] largerArray = new T[count + 1];
            for(int i = 0; i < count; i++)
            {
                largerArray[i] = newArray[i];
            }
            largerArray[count] = item;
            count++;
            newArray = largerArray;
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
            for(int index = 0; index < newArray.Length; index++)
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
            string newString = "";
            foreach (T item in newArray)
            {
                string str = newString + "," + item;
                newString = str;
            }
            newString = newString.Remove(0, 1);
            return newString;
        }
    }
}
