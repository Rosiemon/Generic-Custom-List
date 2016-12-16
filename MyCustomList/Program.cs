using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("THIS IS A GENERIC LIST");
            Console.ReadKey();

            CustomList<int> list1 = new CustomList<int>();
            Console.WriteLine("LIST 1");
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);
            list1.Add(5);
            list1.Display();
            Console.ReadKey();

            CustomList<int> list2 = new CustomList<int>();
            Console.WriteLine("LIST 2");
            list2.Add(6);
            list2.Add(7);
            list2.Add(8);
            list2.Add(9);
            list2.Add(10);
            list2.Display();
            Console.ReadKey();

            Console.WriteLine("ZIPPED LIST");
            CustomList<int> zippedList = new CustomList<int>();
            var zip = list1.Zip(list2, (a, b) => (a + "    " + b));
            foreach (string item in zip)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

            string ToString = list1.ToString();
            string ConvertedToString = list2.ToString();
            Console.WriteLine(ToString);
            Console.WriteLine(ConvertedToString);
            Console.ReadKey();
        }
    }
}
