using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{

    public class Student : Person
    {

        String Major;

        double GPA;

        public Student()
        {
            Major = "";
            this.GPA = 0;
        }

        public String getMajor()
        {
            return Major;
        }

        public void setMajor(String major)
        {
            Major = major;
        }

        public double getGPA()
        {
            return GPA;
        }

        public void setGPA(double GPA)
        {
            this.GPA = GPA;
        }

        public void Display()
        {
            base.Display();
            Console.WriteLine("Major: " + Major);
            Console.WriteLine("GPA: " + GPA);
        }

    }

}