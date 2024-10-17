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
    }
      public Student(string oName,string oAddress,double oMark )
  {
      name = oName;
      address = oAddress;
      mark = oMark;
  }     
    
    
    internal class Program
    {
        static void Main(string[] args)
        {
              Student st = new Student("Muaqtda","4747890",86.56);

  Console.WriteLine($"my name is {st.Name} amd my address is {st.Address} amd my mark is {st.Mark}");
  Console.ReadLine ();

        }
    }
}
