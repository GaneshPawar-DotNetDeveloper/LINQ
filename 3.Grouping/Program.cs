using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grouping
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
               new student {id=6,name="danesh",age=20 },
           };
            Console.WriteLine("----all student----");
            foreach (student i in names)
            {
                Console.WriteLine($" id: {i.id}  name: {i.name} age : {i.age}");
            }

            // for gruoping we can use group by method:

           // var gruoups = names.GroupBy(s => s.age);
            var gruoups = names.ToLookup(s => s.age);


            foreach (var i in gruoups)
            {
                Console.WriteLine($"age : {i.Key} count :{i.Count()}");

                foreach (var item in i)
                {
                    Console.WriteLine($"name : {item.name}");
                }
                Console.WriteLine("----------------------------------------");
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
}
