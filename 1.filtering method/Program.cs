using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.filtering_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* List<student> sc = new List<student>()
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
*/


            // anonymous method:
          /*  IEnumerable<student> filteredstudent = sc.Where( delegate (student s)
                {
                    if(s.age == 23)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                       
                    }
                });
            foreach (student item in filteredstudent)
            {
                Console.WriteLine($"id {item.id}  name: {item.name} age : {item.age}");
            }*/








            // by lambda expression:
            /* IEnumerable<student> name = sc.Where(s => s.age == 29);
             foreach (student item in name)
             {
                 Console.WriteLine($"id:{item.id} name: {item.name} age: {item.age}");
             }*/


           /* // using query method:

           // IEnumerable<student> ww=  this replace with var keyword:
           var ww= from s in sc
                   where s.name.StartsWith("g")
                   select s;
            foreach (student item in  ww)
            {
                Console.WriteLine(item.name);
            }*/



            // we have object type array and in that array there is mixed datatype values are there
            // so i want to fetch only int value with use of where method. 

            List<object> list= new List<object>()
            {
                10,"ganesh",10.5f,"BAMD",20,456,"pql"
            };


            //anonymous method
            /*   var result = list.Where(delegate (object o)
               {
                   return o.GetType().Name == "Int32";
               });
               foreach (var item in result)
               {
                   Console.WriteLine(item);
               }*/
            // lamda expression:

            // var results = list.Where(a => a.GetType().Name == "Int32");
            /*  var results = list.Where(a => a.GetType().Name == "String");
              foreach (var item in results)
              {
                  Console.WriteLine(item);

              }*/
            // so here to reduce that confusion we can use oftype method:

            var result = list.OfType<float>();
            foreach (var item in result )
            {
                Console.WriteLine(item);
            }





            Console.ReadLine();
        }
    }
    public class student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
    }
}
