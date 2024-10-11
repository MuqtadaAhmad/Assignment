using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static my_home_Work.Student;

namespace my_home_Work
{
    public class Student
    {
        private string name;
        private string address;
        private double mark;
        public Student()
        { 
        
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public double Mark
        {
            get { return mark; }
            set { mark = value; }
        }

       public class StudentPrint
        {
         
            public   StudentPrint(string oName, string oAddress, double oMark)
            {
                Student stu = new Student();
                Console.WriteLine();
                stu.Name = oName;
                Console.WriteLine($"the student's name is {oName}");
                stu.Address = oAddress;
                Console.WriteLine($"the stodent's addresso {oAddress} ");
                stu.Mark = oMark;
                Console.WriteLine($"the stodent's mark is {oMark}");



            }
            

        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentPrint st = new StudentPrint("ali","4435",64);
            Console.ReadLine ();

        }
    }
}
