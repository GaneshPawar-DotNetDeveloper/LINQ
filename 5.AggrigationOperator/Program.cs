using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.AggrigationOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // we have
            //1.aggrigate,avarage,count,longcount,min,max,sum 

            List<int> number=new List<int>() {1,2,3,4,5 };
            //aggrigate function:
            int r = number.Aggregate((a, b) => a + b);
            Console.WriteLine(r);
            int r2 = number.Aggregate((a, b) => a - b);
            Console.WriteLine(r2);
            
            int r3 = number.Aggregate((a, b) => a * b);
            Console.WriteLine(r3);
            
            int r4 = number.Aggregate((a, b) => a % b);
            Console.WriteLine(r4);

            // 2.count
            int q=number.Count();
            Console.WriteLine(q);

            //3. avarage :
            double qa=number.Average(); // here we use double 
            Console.WriteLine(qa);

            // 4.long count:
            long s = number.LongCount();
            Console.WriteLine(s);

            // 5. min method:
            int d = number.Min();
            Console.WriteLine(d);

            // 6. max:
            int e = number.Max();
            Console.WriteLine(e);

            //7.sum method:
            int result=number.Sum();
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
