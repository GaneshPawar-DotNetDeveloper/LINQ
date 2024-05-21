using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
      // conversion we can use to simply convert in linq functions to achive use functionality od linq namespace
       
            List<int> number=new List<int>() {1,2,3,4,5,6 };
            // it is generic list 

            //AsEnurable:
            IEnumerable<int> number1 = number.AsEnumerable();
            IQueryable<int> number2=number.AsQueryable();
            IEnumerable<short> number3 = number.Cast<short>();
            int[] number4=number.ToArray();
            List<int> number5=number.ToList();
            Dictionary<int, int> number6 = number.ToDictionary(i => i);
            foreach (var kvp in number6)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
            string s = "ganesh";
            char[] chars= s.ToCharArray();

            Console.WriteLine($"{number1},{number2},{number3},{number4},{number5},{number6},{chars}");

            Console.ReadLine(); 

        }
    }
}
