using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> name=new List<string>()
            {
                "suresh","ganesh","mahesh","shailesh","ramesh"
            };

            // so  here i want to write code for get name which is start with 's'

            Console.WriteLine("----starts with s----");

            IEnumerable<string> getname = name.Where(delegate (string s)
            {
                return s.StartsWith("s");
            });
            foreach (string item in getname)
            {
                Console.WriteLine(item);
            }

            // with lambda expression:
            Console.WriteLine("---starts with g----");
            IEnumerable<string> names = name.Where(s => s.StartsWith("g"));
            foreach (string s in names)
            {
                Console.WriteLine(s);
            }
           
        List<int> numbers= new List<int>() {10,33,63,56,32,64,76 };

            Console.WriteLine("divisible by 2 ");
            IEnumerable<int> numbers2 = numbers.Where(delegate (int a)
            {
                return  a%2==0;
            });
            foreach (int item in numbers2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---divisible by 3 ---");
            IEnumerable<int> div = numbers.Where(b => b%3==0);
            foreach (int item in div)
            {
                Console.WriteLine(item);
            }

        Console.ReadLine();
        }
    }
}
