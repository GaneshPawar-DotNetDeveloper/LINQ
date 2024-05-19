using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // it is a simplified way to write a anonymous method.

            List<student> students = new List<student>()
            {
                new student() {id=1,name="suraj"},
                new student() {id=2,name="ganesh"},
                new student() {id=3,name="ramesh"},
                new student() {id=4,name="mahesh"},
            };
            Console.WriteLine("-----all student------");
            foreach (student item in students)
            {
                Console.WriteLine($"  id : {item.id}   name : {item.name}");
            }


            Console.WriteLine("-----filtered student----------");
            // anonymous method:
            /*  IEnumerable<student> filterdstudents = students.Where(delegate (student s)
              {
                  return s.id>=1 && s.id<3;
              });

              foreach (student item in filterdstudents)
              {
                  Console.WriteLine($" id : {item.id}  name : {item.name}");
              }*/

            // using lambda expression
            // =>  is such that/goes to operator.

            IEnumerable<student> students2 = students.Where(s => s.id >= 1 && s.id < 3);
              // this is lambda expression
               





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
