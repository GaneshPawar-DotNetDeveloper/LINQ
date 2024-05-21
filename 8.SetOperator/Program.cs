using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.SetOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>() { 1, 2, 3, 2, 1, 1, 4, 5, 5 };
            Console.WriteLine("------All elemets------");
            foreach (int i in num)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // so here i want unique value 
            // so for that we use distinct
            Console.WriteLine("-----Distinct-----");
            IEnumerable<int> n = num.Distinct();
            foreach (var item in n)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            Console.WriteLine("------Except-------");
            List<int> list1 = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> list2 = new List<int>() { 4, 5, 6, 7 };

            IEnumerable<int> numb = list1.Except(list2);
            foreach (var item in numb)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            Console.WriteLine("-----Intersect------");
         IEnumerable<int> s=   list1.Intersect(list2);
            foreach (var item in s)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            Console.WriteLine("-----union------");

      IEnumerable<int> j=      list1.Union(list2);
            foreach (var item in j)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            Console.WriteLine("-----Concat-----");
        IEnumerable<int>  n2=  list1.Concat(list2);
            foreach (int item in n2)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
