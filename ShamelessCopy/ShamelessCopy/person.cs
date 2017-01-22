using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamelessCopy
{
    
    public class person
    {
        private static int NumberReferences = 0;

        public static int NumReferences()
        {
            return NumberReferences;
        }

        protected string m_FirstName;
        protected string m_LastName;
        protected int m_age;

        protected string m_Haircolor;

        
        public void SetFirstName(string firstname)
        {
            m_FirstName = firstname;
        }
        
        public string FirstName
        {
            get
            {
                return m_FirstName;
            }
            set
            {
                m_FirstName = value;
            }
        }

        public int age
        {

            get
            {
                return m_age;
            }

            set
            {
                m_age = value;
            }

        }

        public string LastName
        {
            get
            {
                return m_LastName;
            }

            set
            {
                m_LastName = value;
            }
        }


        

        protected person()
        {
            m_FirstName = "Jane";
            m_LastName = "Doe";
            m_age = 0;
            m_Haircolor = "Ginger";

        }

        public String HairColor
        {
            set
            {
                m_Haircolor = value;
            }

            get
            {
                return m_Haircolor;
            }
        }
       

        public person(string fn, string ln, int age, string haircolor)
        {
            NumberReferences = NumberReferences + 1;
            m_FirstName = fn;
            m_LastName = ln;
            m_age = age;
            m_Haircolor = haircolor;
        }

        public person(ref person p)
        {

        }

        public void PrintOutContent()
        {
            Console.WriteLine("First name = " + m_FirstName);
            Console.WriteLine("Last name = " + m_LastName);
            Console.WriteLine("Age = " + m_age);
            Console.WriteLine("Hair color = " + m_Haircolor);
        }
    }
}
