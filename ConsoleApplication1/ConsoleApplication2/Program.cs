public class Person {

     string Name, Address, Phone, Email;

     public void setPhone(string phone) { Phone=phone; }

     public string getPhone() { return Phone; }

     public void setAddress(string address) { Address=address; }

     public string getAddress() { return Address; }

     public void setEmail(string email) { Email=email; }

     public string getEmail() { return Email; }

     public void setName(string name) { Name=name; }

     public string getName() { return Name; }

     public PersonPrint() { Console.WriteLine(Name);Console.Writeline(Address);Console.Writeline(Phone);Console.Writeline(Email);

    }

}

public class Student: public Person {

      String Major;

     double GPA;

     public Student() { Name=""; Address=""; Phone=""; Email=""; Major=""; GPA=0; }

     public void setGPA(double gpa) { GPA=gpa; }

     public double getGPA() { return GPA; }

     public void setMajor(string major) { Major=major; }

     public string getMajor() { return Major; }

}