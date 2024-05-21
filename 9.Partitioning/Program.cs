using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Partitioning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>() { 1, 2, 3, 2,4,5,6};
            Console.WriteLine("------All elemets------");
            foreach (int i in num)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // so here i want skip the three element
            // for that we use skip method
            Console.WriteLine("-----------skip---------");
            IEnumerable<int> number = num.Skip(4);
            foreach (int i in number)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine("-----skipwhile-----");
            IEnumerable<int> gh = num.SkipWhile(i => i < 3);
            foreach (int i in gh)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

              IEnumerable<int> ghi = num.SkipWhile(i => i > 3); // here condition pahile hi fail ho jayegi isiliye 
                                                        // ye all data retrive karega.
            foreach (int i in ghi)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine("-------Take-------");
            // it is alternate of skip
            // jab tak condition true hoga tab tak ye take karata rahega.
            IEnumerable<int> s=num.Take(2);
            foreach (int i in s)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("------TakeWhile------");
    IEnumerable<int> w=        num.TakeWhile(i => i > 3);
            foreach (var item in w)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            // it give empty bcs-it get first false condition then it can't take enything.

            IEnumerable<int> wa = num.TakeWhile(i => i <3);
            foreach (var item in wa)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

               IEnumerable<int> waa = num.TakeWhile(i => i%2==0);
            foreach (var item in waa)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

                IEnumerable<int> waah = num.TakeWhile(i => i%2!=0);
            foreach (var item in waah)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
