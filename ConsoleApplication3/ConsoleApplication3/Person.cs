using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{

    public class Person
    {

        String Name, Address, Phone, Email;

        public Person()
        {
            Name = "";
            Address = "";
            Phone = "";
            Email = "";
        }

        public String getName()
        {
            return Name;
        }

        public void setName(String name)
        {
            Name = name;
        }

        public String getAddress()
        {
            return Address;
        }

        public void setAddress(String address)
        {
            Address = address;
        }

        public String getPhone()
        {
            return Phone;
        }

        public void setPhone(String phone)
        {
            Phone = phone;
        }

        public String getEmail()
        {
            return Email;
        }

        public void setEmail(String email)
        {
            Email = email;
        }

        public void Display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Phone: " + Phone);
            Console.WriteLine("Email: " + Email);
        }

    }

}