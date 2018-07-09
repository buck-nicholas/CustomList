using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ListMethod<T> listMethods = new ListMethod<T>();
            ListMethod<int> myList = new ListMethod<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Add(6);
            foreach (int item in myList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
