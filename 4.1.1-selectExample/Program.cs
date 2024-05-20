using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1._1_selectExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

/*
 task: I have a list of string which contains names and i want to project this list to a list of students
       and assign all name to student names.

 */

            List<string> name= new List<string>() { "shubham","aniket","vidhya","shital","rahul"};

            // so i want that list of string collection can use as a student collection

            IEnumerable<student> students = name.Select(s => new student() { name = s });
            foreach (var student in students)
            {
                Console.WriteLine(student.name);
            }
        
        
        
        Console.ReadLine();

        }
    }
    public class student
    {
        public string name;
    }
}
