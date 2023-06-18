using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheiratance
{
    internal class Student : person //task1
    {
        int studentID;
        string major;
        public Student(string name, int age, int studentID, string major) : base(name, age)
        {
            this.studentID = studentID;
            this.major = major;
        }
        public void getInformation()
        {
            Console.WriteLine(name+" "+age+" "+studentID+" "+major);
        }
    }
}
