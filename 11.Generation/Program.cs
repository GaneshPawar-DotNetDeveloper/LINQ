using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Generation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // IEnumerable <int> num= new List<int>() {1,2,3,4 };
            /// IEnumerable<int> num2 = null;
           //string s= string.Empty; // it give more readiability.
           IEnumerable<string> bb=new List<string>();
            IEnumerable<int> number=new List<int>();
            Console.WriteLine($" count :{number.Count()}");


            Console.WriteLine("DefaultIfEmpty : ");
            IEnumerable<int> number2=Enumerable.DefaultIfEmpty(number); // here it count a default value
            Console.WriteLine($" count :{number2.Count()}");

            IEnumerable<string> result= Enumerable.DefaultIfEmpty(bb);
            Console.WriteLine($"count : {bb.Count()}");

            // string value is null so it default value is null so count is also zero.


            Console.WriteLine("Empty method");

            IEnumerable<int> result3=Enumerable.Empty<int>();
            Console.WriteLine($"count : {result3.Count()}");
            // it give rediability.
            Console.WriteLine("range method");
            IEnumerable<int> s = Enumerable.Range(1,345);
            foreach(int i in s)
            {
                Console.Write(i +" ");
            }
            Console.WriteLine();

            Console.WriteLine("Repeat");
            IEnumerable<int> sw = Enumerable.Repeat(20, 12);
            foreach(int i in sw)
            {
                Console.Write(i +" ") ;
            }
            Console.WriteLine();


            /* IEnumerable<string> result1= Enumerable.DefaultIfEmpty(number);
            Console.WriteLine($"count : {bb.Count()}");
*/




            Console.ReadLine();
        }
    }
}
