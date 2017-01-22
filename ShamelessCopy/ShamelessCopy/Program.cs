using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShamelessCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            

            student pA = new student("John", "Clauske", 20, "Dark", 3.5f);
            student pB = new student("Allen", "Walker", 19, "Dark", 2.0f);
            student pC = new student("Yuuya", "Sumeragi", 20, "Dark", 1.5f);
            student pD = new student("Luis", "McKenzie", 15, "brown", 3.0f);
            

            pA.PrintOutContent();


            pA.PrintGPA(pA.m_gpa);

            Console.WriteLine("Number of items created " + person.NumReferences());

            A.Dictionary_totorial();
            Student_Roster roster = new Student_Roster();
            roster.Add(pA.ID, pA);
            roster.Add(pB.ID, pB);
            roster.Add(pC.ID, pC);
            student Chris = roster[2];

            pA.m_IPrinter = new ConsolePrinter();
            pB.m_IPrinter = new GuiPrinter();

            pA.Debug();
            pB.Debug();


            Console.ReadLine();

        }
    }
}