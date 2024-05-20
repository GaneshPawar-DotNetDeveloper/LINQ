using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _6.Quantifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // it return always as a boolean return type.
            // in Qantifiers there age three methods are present:
           /* List<int> list = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18
            };
            bool resul = list.All(a => a < 20);
            Console.WriteLine(resul);

            bool result= list.All(a => a > 15);
            Console.WriteLine(result);

            bool r=list.Any(a => a < 2);
            Console.WriteLine(r);
*/

            student s2= new student() { id = 1, name = "ajay", age = 22, subjects = new List<string>() { "s1" } };
            List<student> students = new List<student>()
            {
                s2,
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
            /* bool resulty = students.Contains(s2);
             Console.WriteLine(resulty);*/
            // it can return true
            // but when we create a object after the list with same part:
            /* student s1= new student() { id = 2, name = "chaitanya", age = 21, subjects = new List<string>() { "s2", "s3" }  };
                      bool resulty = students.Contains(s1);
                      Console.WriteLine(resulty);*/
            // it returns false

            // because hamne equal operator me dekha tha ki vo valueEquality check nahi karata
            // so for that we can need get override

            /* student s1 = new student() { id = 2, name = "chaitanya", age = 21, subjects = new List<string>() { "s2", "s3" } };
             bool resulty = students.Contains(s1);
             Console.WriteLine(resulty);
 */



            // without override how we can achive:
            // for that we can use IEqualityComparer<T>
            // to iso impliment karane ke liye hum yek class create karake usko ye impliment kar sakate he.
            // 

            student s1 = new student() { id = 2, name = "chaitanya", age = 21, subjects = new List<string>() { "s2", "s3" } };
            bool resulty = students.Contains(s1,new studenthelper());
            Console.WriteLine(resulty);





            Console.ReadLine();
        }
    }
    public class student
    {
        public int id;
        public string name;
        public int age;
        public List<string> subjects { get; set; }

      /*  public override bool Equals(object obj)
        {
            student s= obj as student; // here type is object so we can get cast in student
            return this.id.Equals(s.id)&& this.name.Equals(s.name)&&this.age.
                Equals(s.age) && this.subjects.SequenceEqual(s.subjects);
        }

        public override int GetHashCode()
        {
            int hash=this.id.GetHashCode() ^ this.name.GetHashCode() ^
                this.age.GetHashCode();
            foreach (var subject in subjects)
            {
                hash ^= subject.GetHashCode();
            }
            return hash;

        }*/

    }
    public class studenthelper : IEqualityComparer<student>
    {
        public bool Equals(student x, student y)
        {
            return x.id.Equals(y.id)&& x.name.Equals(y.name)&&x.age.Equals(y.age)&&
                x.subjects.SequenceEqual(y.subjects);

        }

        public int GetHashCode(student obj) 
        {
        return    obj.id.GetHashCode() ^ obj.name.GetHashCode() ^ obj.age.GetHashCode() ^ obj.subjects.GetHashCode();
        }
    }
}
