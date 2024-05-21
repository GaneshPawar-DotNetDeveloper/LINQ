using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.ElementOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
          /*
            there is 8 element operator methods:
           1.ElementAt
          2.ElementAtorDefault
          3.first
          4.firstOrDefault
          5.last
          6.lastOrdefault
          7.single
          8. singleOrdefault
           */

            List<int> list = new List<int>() {1,2,3,4,5,6,7,8,9 };

            // elementAt:
            int num=list.ElementAt(0);
            Console.WriteLine(num);
            int num1=list.ElementAt(5);
            Console.WriteLine(num1);
            /* int num2=list.ElementAt(10);
             Console.WriteLine(num); */
           /* int num2 =list.ElementAt(i=>i%2==0); //--> it is not delegate type (can't convert => to int type) 
            Console.WriteLine(num2);*/

            int num3 = list.ElementAtOrDefault(10);
            Console.WriteLine(num3);

            /* int num4 = list.ElementAtOrDefault(i => i % 2 == 0);
             Console.WriteLine(num4);*/

            //last operator:
            Console.WriteLine("last operator");
            int num5 = list.Last();
            Console.WriteLine(num5);

            int nun6 = list.Last(i => i <3);
            Console.WriteLine(nun6);
            
            int nun7 = list.Last(i => i%2==0);
            Console.WriteLine(nun7);

            /*int nun8 = list.Last(i => i%99==0);
            Console.WriteLine(nun8);*/
            Console.WriteLine("lastordefault");
            int nun8 = list.LastOrDefault(i => i % 99 == 0);
            Console.WriteLine(nun8);

            Console.WriteLine("first");
            int number = list.First();
            Console.WriteLine(number);
            int number1 = list.First(i => i % 2 == 0);
            Console.WriteLine(number1);
            /* int number3 = list.First(i => i * 18 == 0);
             Console.WriteLine(number3);*/

            int number3 = list.FirstOrDefault(i => i * 18 == 0);
            Console.WriteLine(number3);

            Console.WriteLine("single");
            /* int numb = list.Single();
             Console.WriteLine(numb);*/
            // single method return first value and single value -it want single valie in collection
            int numbs = list.First(i=>i%9==0) ;
            Console.WriteLine(numbs);
            /*int numbs2 = list.SingleOrDefault();
            Console.WriteLine(numbs2);*/
            int numbs2 = list.SingleOrDefault(i=>i>12);
            Console.WriteLine(numbs2);

            Console.ReadLine();
        }
    }
}
