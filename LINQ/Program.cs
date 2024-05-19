using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<student> sc=new List<student>()
            {
                new student() {id=1,name="suraj",age=27},
                new student() {id=2,name="ganesh",age=25},
                new student() {id=3,name="raj",age=23},
                new student() {id=4,name="samir",age=29}
            };
            Console.WriteLine("------all students-------");

            foreach (student item in sc)
            {
                Console.WriteLine($"{item.id} {item.name} {item.age}");
            }

            // traditional way of syntax:
            /* List<student> filteredstudent = new List<student>();
             foreach (student item in sc)
             {
                 if(item.age>=25 && item.age <= 30)
                 {
                     filteredstudent.Add(item);
                 }
             }*/
            /* Console.WriteLine("----filtered student-----");
             foreach (student item in filteredstudent)
             {
                 Console.WriteLine($"{item.id} {item.name} {item.age}");
             }
 */
            // linq query syntax:
            /*
                        IEnumerable<student> filteredstudent = from item in sc where item.age >= 25 &&
                                                               item.age <= 30 select item;

                        Console.WriteLine("----filtered student-----");
                        foreach (student item in filteredstudent)
                        {
                            Console.WriteLine($"{item.id} {item.name} {item.age}");
                        }*/


            // linq method syntax:

            /*   IEnumerable<student> filteredstudent = sc.Where(delegate (student s)
               {
                   return s.age>=28 && s.age<=30;
               });*/

            // OR
            Func<student, bool> del = delegate (student s)
            {
                return s.age >= 28 && s.age <= 30;
            };
            IEnumerable<student> filteredstudent = sc.Where(del);

            Console.WriteLine("----filtered student-----");
            foreach (student item in filteredstudent)
            {
                Console.WriteLine($"{item.id} {item.name} {item.age}");
            }
            Console.ReadLine();
        }  
    }
    public class student
    {
        public int id {get;set;} 
        public string name {get;set;} 
        public int age {get;set;} 
    }
}
