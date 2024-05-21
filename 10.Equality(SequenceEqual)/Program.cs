using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Equality_SequenceEqual_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // sequence same he ki nahi ye check karane ke liye hum use karenge.
            // return boolean value
            // there are two overloads
            // isme element+sequence same hona mendatary he.

            List<int> num1 = new List<int>() {1,2,3,4,5 };
            List<int> num2 = new List<int>() {1,2,3,4,5 };
        bool i= num1.SequenceEqual(num2);
            Console.WriteLine(i);
            Console.WriteLine("------");


            List<int> num11 = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> num22 = new List<int>() { 1, 3, 2, 4, 5 };

            bool n= num11.SequenceEqual(num22);
            Console.WriteLine(n);
            Console.WriteLine("-------------");

            List<int> num111 = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> num222 = new List<int>() { 1, 3, 2, 4, 5 };

            num111.Sort();
            num222.Sort();
            bool n1 = num111.SequenceEqual(num222);
            Console.WriteLine(n1);

            Console.WriteLine("------------------------------------------");
            List<int> nu = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> nun = new List<int>() { 1, 3, 2 };

            bool s2= nu.SequenceEqual(nun);
            Console.WriteLine(s2);


            Console.ReadLine();
        }
    }
}
