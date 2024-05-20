using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1SortMethod_4_Overloads
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
          In sort method there are 4 overloads :
            these are :
            1.parameterleass :
            2.Icomparer :
            3. start,count,Icomparer :
            4. comparison :

          */

            List<int> student=new List<int>()
            {
                12,3,4,56,22,54,65,876
            };
            student.Sort();
            foreach(int i in student)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            List<string> name = new List<string>()
            {
                "ganesh","radha","krushna","ridhi","sidhi","shankar","parvati"
            };
            name.Sort();
            foreach(string s in name)
            {
                Console.WriteLine(s);
            }

            // it can give output 
            // but when we applly on complex type then it give exception beacause it can't understand on what
            //  basis it can  get sort. 

            List<student> names = new List<student>() {
               new student {id=1,name="ganesh",age=25 },
               new student {id=2,name="sanesh",age=22 },
               new student {id=3,name="sugnesh",age=22 },
               new student {id=4,name="viganesh",age=20 },
               new student {id=5,name="kanesh",age=29 },
               new student {id=6,name="danesh",age=28 },
           };
            Console.WriteLine("----sort method use");
                  names.Sort(); // here it give InvalidOperation Exception.
                          // bcs.it cant understand which item we can sort.
            foreach (student i in names)
            {
                Console.WriteLine($" id {i.id} name : {i.name}  age : {i.age}");
            }

            // to overcome that problem we can impliment IComparable method


            Console.ReadLine();
        }

    }
    public class student :IComparable
    {
      public int id;
        public string name;
        public int age;

        public int CompareTo(object obj)
        {
            // here parameter is object type but our datatype is student type 
            // so we need to get type cast 
            student s=obj as student;

            // here compareTo method returns three states
            // like 1,-1 and zero
           /* if (this.age > s.age)
            {
                return 1;
            }
            else if(this.age < s.age)
            {
                return -1;
            }
            else
            {
                return 0;
            }*/
           // to avoid that line of code we can use direct conpareTo method:
           return this.age.CompareTo(s.age);
        }
    }
}
