using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public enum Salutation
    {
        Mr=0,
            Ms=1,
            Mrs=2,
            Dr=3
    }
    class Student
    {
        public int Rollno{ get; set; }
        public string name{ get; set; }
        public string Gender{ get; set; }
        static void Main(string[] args)

        {
            Student student = new Student();
            student.Rollno = 1;
            student.name = "Abd";
            student.Gender = "Male";
            Console.WriteLine(+student.Rollno);
            Console.WriteLine(student.name);
            Console.WriteLine(student.Gender);
        }
        static void  Main1(string[] args)
        { 

            Salutation salutation;
            string name1();
            Console.WriteLine("Enter Salutatiom");
            salutation = (Salutation)Enum.Parse(typeof(Salutation), Console.ReadLine());
            Console.WriteLine("Enter name");
            Console.Write("\nYour name is : {0}");
            Console.Write("." , name1);

            Console.ReadLine();
        }
    }
}
