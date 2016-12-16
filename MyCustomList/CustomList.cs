using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomList
{
    public class CustomList<T> : IEnumerable<T>
    {
        public T[] list;
        private int capacity;
        private int count;
        private int index;
        private string convertedString;

        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }

        public int Count 
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }

        public CustomList()
        {
            capacity = 0;
            list = new T[capacity];
        }
        
        public T this[int index]
        {
            get
            {
                return list[index];
            }
            set
            {
                list[index] = value;
            }
        }

        public void Add(T item)
        {
            T[] newList = new T[list.Count() + 1];
            for (int index = 0; index < list.Count(); index++)
            {
                newList[index] = list[index];
            }
            newList[list.Count()] = item;
            list = newList;
            count++;
        }

        public void Insert(T item)
        {
            if (count >= capacity)
            {
                T[] newList = new T[capacity = capacity * 2];
                for (int index = 0; index < count; index++)
                {
                    newList[index] = list[index];
                }
                newList[index] = item;
                list = newList;
                count++;
            }
            else
            {
                list[index] = item;
                count++;
            }
        }

        public void Remove(T item)
        {
            T[] newList = new T[list.Count()];
            for (int index = 0; index <= count; index++)
            {
                if (item.Equals(list[index]))
                {
                    count--;
                }
                else
                {
                    newList = list;  
                }
            }
        }

        public static CustomList<T> operator -(CustomList<T> list1, CustomList<T> list2)
        {
            foreach (T item in list2.list)
            {
                list1.Remove(item);
            }
            return list1;
        }

        public static CustomList<T> operator +(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> mergedLists = new CustomList<T>();
            foreach (T item in list1.list)
            {
                mergedLists.Add(item);
            }
            foreach (T item in list2.list)
            {
                mergedLists.Add(item);
            }
            return mergedLists;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int index = 0; index < list.Count(); index++)
            {
                yield return list[index];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString()
        {
            convertedString = "Converted String : ";
            for (index = 0; index < list.Length; index++)
            {
                convertedString = convertedString + " " + list[index];
            }
            return convertedString;
        }

        //public CustomList<T> Zipped(CustomList<T> list1, CustomList<T> list2)
        //{
        //    CustomList<T> zippedList = new CustomList<T>();
        //    for (int index = 0; index < list.Count(); index++)
        //    {
        //        zippedList.Add(list1[index]);
        //        zippedList.Add(list2[index]);
        //    }
        //    return zippedList;
        //}

        public void Display()
        {
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}