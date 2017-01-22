using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Student p = new Student();
            p.setName("John");
            p.setAddress("Portugal");
            p.setPhone("1234567890");
            p.setEmail("ronaldogmail.com");
            p.setMajor("football");
            p.setGPA(3.6);
            p.Display();

            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}