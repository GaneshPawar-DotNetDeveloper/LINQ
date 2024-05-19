using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.SortingMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<student> students = new List<student>()
            {
                new student() {rollnumber=1,name="mahesh",age=27},
                new student() {rollnumber=2,name="ganesh",age=25},
                new student() {rollnumber=3,name="rajesh",age=23},
                new student() {rollnumber=4,name="suresh",age=21},
                new student() {rollnumber=5,name="mangesh",age=23},
            };
            Console.WriteLine("\n----All students-----");
            foreach (student item in students)
            {
                Console.WriteLine($"rollnumber :{item.rollnumber}  name: {item.name}  age: {item.age}");
            }

            Console.WriteLine("\n----sorted on age by acending----");
            IOrderedEnumerable<student> sorting = students.OrderBy(delegate (student s){ return s.age;});
            foreach (student item in sorting)
            {
                Console.WriteLine($"rollnumber :{item.rollnumber}  name: {item.name}  age: {item.age}");

            }

            Console.WriteLine("\n-----sorted on age by desending");
            IOrderedEnumerable<student> sortingdes = students.OrderByDescending(s => s.age);
            foreach (student item in sortingdes)
            {
                Console.WriteLine($"rollnumber :{item.rollnumber}  name: {item.name}  age: {item.age}");

            }

            // here age is same for age=23 so i want also sort with name :


            Console.WriteLine("\n------sorted  on age descending and name in ascending-----");
            IOrderedEnumerable<student> sort = students.OrderByDescending(s => s.age).ThenBy(s => s.name);
            foreach (student item in sort)
            {
                Console.WriteLine($"rollnumber :{item.rollnumber}  name: {item.name}  age: {item.age}");

            }
            Console.WriteLine("\n---sorted on age descending and name in also descending---");
            IOrderedEnumerable<student>sorty=students.OrderByDescending(s => s.age).ThenByDescending(s => s.name);
            foreach (student item in sorty)
            {
                Console.WriteLine($"rollnumber :{item.rollnumber}  name: {item.name}  age: {item.age}");

            }

            Console.WriteLine("\n---sorted on age Ascending and name in decending");
            IOrderedEnumerable<student> sor = students.OrderBy(a => a.age).OrderByDescending(b => b.name);
            foreach (student item in sor)
            {
                Console.WriteLine($"rollnumber :{item.rollnumber}  name: {item.name}  age: {item.age}");

            }

            Console.WriteLine("\n---reverse method---");

            IEnumerable<student> reverseing=sorting.Reverse();
            foreach (student item in reverseing)
            {
                Console.WriteLine($"rollnumber :{item.rollnumber}  name: {item.name}  age: {item.age}");

            }
            Console.WriteLine(" \n we can revrese our collection as it is :");

            students.Reverse();
            foreach (student item in students)
            {
                Console.WriteLine($"rollnumber :{item.rollnumber}  name: {item.name}  age: {item.age}");

            }


            Console.ReadLine();
        }
    }
    public class student
    {
        public int rollnumber;
       public string name;
       public int age;

    }
}
