using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamelessCopy
{
    public class student : person, IContactable, IDebug
    {
        private static int id = 0;
        public float m_gpa;
        private int m_id;
        public string m_email;
        public string m_PhoneNumber;

        public IPrinter m_IPrinter;

        public void Debug()
        {
            string everything = "First name = " + m_FirstName + " Last name = " + m_LastName + " age =" + m_age + " Hair Color = " + m_Haircolor + " gpa = " + m_gpa;
            m_IPrinter.Print(everything);
        }

        public string Email
        {
            get
            {
                return m_email;
            }
            set
            {
                m_email = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return m_PhoneNumber;
            }
            set
            {
                m_PhoneNumber = value;
            }
        }


        public float GPA
        {
            get
            {
                return m_gpa;
            }
            set
            {
                m_gpa = value;
            }

        }


        public static int Id()
        {
            return id;
        }

        public int ID
        {
            get
            {
                return m_id;
            }

            set
            {
                m_id = value;
            }

        }



        public student(string fn, string ln, int age, string haircolor, float gpa)
            : base(fn, ln, age, haircolor)
        {
            m_gpa = gpa;
            id = id + 1;
            m_id = id;
        }

        public void PrintGPA(float m_gpa)
        {
            Console.WriteLine("gpa = " + m_gpa);
            Console.WriteLine("id = " + id);

        }

    }
}
