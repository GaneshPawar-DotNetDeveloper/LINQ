using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2_Sort_IcomparerInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<student> names = new List<student>() {
               new student {id=1,name="ganesh",age=25 },
               new student {id=2,name="sanesh",age=22 },
               new student {id=3,name="sugnesh",age=22 },
               new student {id=4,name="viganesh",age=20 },
               new student {id=5,name="kanesh",age=29 },
               new student {id=6,name="danesh",age=28 },
           };
            Console.WriteLine("----all student----");
            foreach (student i in names)
            {
                Console.WriteLine($" id: {i.id}  name: {i.name} age : {i.age}");
            }
           // Console.WriteLine("-----sort with using comparer method-----");

            IComparer<student> comparer = new studenthepper();
            /*names.Sort(comparer);
            foreach  (student i in names)
            {
                Console.WriteLine($" id: {i.id}  name: {i.name} age : {i.age}");

            }*/
            Console.WriteLine("----sort using index-count-Icomparer");
            Console.WriteLine("--use for sort limeted records----");

            names.Sort(0,3,comparer);
            foreach (student i in names)
            {
                Console.WriteLine($" id: {i.id}  name: {i.name} age : {i.age}");

            }
            Console.WriteLine("--sort by using comparision method---");
            names.Sort((x, y) => x.age.CompareTo(y.age));
            foreach (student i in names)
            {
                Console.WriteLine($" id: {i.id}  name: {i.name} age : {i.age}");

            }

            Console.ReadLine();
        }
    }
    public class student 
    {
        public int id;
        public string name;
        public int age;
    }
    public class studenthepper : IComparer<student>
    {
        public int Compare(student x, student y)
        {
           return x.age.CompareTo(y.age);
        }
    }
}
