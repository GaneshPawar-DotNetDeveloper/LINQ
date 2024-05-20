using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1_select_many
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<student> students = new List<student>()
            {
                new student() {id=1,name="ajay",age=22 ,subjects=new List<string>(){"s1" } },
                new student() {id=2,name="chaitanya",age=21,subjects=new List<string>(){"s2","s3" }},
                new student() {id=3,name="kishore",age=27,subjects=new List<string>(){"s2","s4" }},
                new student() {id=5,name="vasudha",age=20,subjects=new List<string>(){"s1","s2","s4" }},
                new student() {id=6,name="shailesh",age=30,subjects=new List<string>(){"s1","s5","s6" }},
                new student() {id=7,name="farin",age=23,subjects=new List<string>(){"s1","s6","s7" }},
                new student() {id=8,name="najim",age=25,subjects=new List<string>(){"s8","s9" }},
                new student() {id=9,name="rupesh",age=28,subjects=new List<string>(){"s1","s5" }},
                new student() {id=10,name="Dhiraj",age=26,subjects=new List<string>(){"s9" }},
            };
            Console.WriteLine("---all student-----");
            foreach (student item in students)
            {
                Console.WriteLine($"id : {item.id} name: {item.name} age:{item.age}");
            }
            // here i want select sunject names
            // so for that we can get by 2 ways:
            // 1. select
            // 2. select many
            Console.WriteLine("--- using select---");
            IEnumerable<List<string>> result = students.Select(s => s.subjects);
            foreach (var subjects in result)
            {
                foreach (var item in subjects)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine("---using selectmany---");
            IEnumerable<string> result1 = students.SelectMany(s => s.subjects);
            foreach (var item in result1) 
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
    public class student
    {
        public int id;
        public string name;
        public int age;
        public List<string> subjects { get; set; }
    }
}
