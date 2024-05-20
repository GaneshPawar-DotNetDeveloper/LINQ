using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ProjectionOprator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<student> students = new List<student>()
            {
                new student() {id=1,name="ajay",age=22},
                new student() {id=2,name="chaitanya",age=21},
                new student() {id=3,name="kishore",age=27},
                new student() {id=5,name="vasudha",age=20},
                new student() {id=6,name="shailesh",age=30},
                new student() {id=7,name="farin",age=23},
                new student() {id=8,name="najim",age=25},
                new student() {id=9,name="rupesh",age=28},
                new student() {id=10,name="Dhiraj",age=26},
            };
            Console.WriteLine("---all student-----");
            foreach (student item in students)
            {
                Console.WriteLine($"id : {item.id} name: {item.name} age:{item.age}");
            }
            // if i want to only names of student 
            // so for that we use select :

            // 1. select :
            Console.WriteLine("---using select we can get only names:");
         IEnumerable<string> sc  = students.Select(s => s.name);
            // name is string return type so for that we use IEnumerable<String> 
            foreach (var item in sc)
            {// here item is string type
                Console.WriteLine(item);
            }



            // I want  students rollnumber+name
            // so for that we can use 
            // 1.create new class
            // 2. by tuple
            //3. using anonumous method

            Console.WriteLine("--get id and name by new class--");

            IEnumerable<copyclass> result = students.Select(s => new copyclass()
            {
                id = s.id,
                name = s.name
            });
            foreach (var item in result)
            {
                Console.WriteLine($"{item.id}  {item.name}");
            }

            Console.WriteLine("----using tuple-----");
            var result1 = students.Select(s => new Tuple<int, string>(s.id, s.name));
            foreach (var item in result1)
            {
                Console.WriteLine($"{item.Item1} {item.Item2}");
            }

            Console.WriteLine("---using Anonymous type---");

            var result2 = students.Select(s => new { id = s.id, name = s.name });
            foreach (var item in result2)
            {
                Console.WriteLine($"{item.id}  {item.name}");
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
    public class copyclass
    {
        public int id;
        public string name;
    }
}
