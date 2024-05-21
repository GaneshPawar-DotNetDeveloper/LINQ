using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _8._1__ComplexTypeCollection
{

    // I want get All Unique data:
    internal class Program
    {
        static void Main(string[] args)
        {
            List<product> item = new List<product>()
            {
                new product(){name="lemon",code=001},
                new product(){name="Apple",code=002},
                new product(){name="Apple",code=002},
                new product(){name="Banana",code=003},
                new product(){name="Banana",code=003},
                new product(){name="graps",code=004},
                new product(){name="clustered",code=005},
                new product(){name="mango",code=006},
                new product(){name="Cocunut",code=007},
                new product(){name="imali",code=008}
            };
            Console.WriteLine("----All Products-----");
            foreach (product i in item)
            {
                Console.WriteLine($"name : {i.name}  code : {i.code}");
            }


            Console.WriteLine("----get all unique data--------");

            IEnumerable<product> dd = item.Distinct(new copyproduct());

            // here we can need to create a new class get impliment equals method.
            foreach (product i in dd)
            {
                Console.WriteLine($"name : {i.name}  code : {i.code}");
            }






            Console.ReadLine();
        }
       
    }
    public class product
    {
        public string name;
        public int code;
    }
    public class copyproduct : IEqualityComparer<product>
    {
        public bool Equals(product x, product y)
        {
            if (x == null || y == null)
                return false;

            return x.name == y.name && x.code == y.code;
        }





        public int GetHashCode(product obj)
        {
            if (obj == null)
                return 0;

            // Combine hash codes of the properties
            int hashName = obj.name == null ? 0 : obj.name.GetHashCode();
            int hashCode = obj.code.GetHashCode();
            return hashName ^ hashCode;
        }
    }
}
