using System;
using System.Collections.Generic;
using System.Text;

namespace ANDREW_Lab1BClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person defaultPerson = new Person();
            Console.Write("First name: ");
            string tempFirst = Console.ReadLine();
            Console.Write("Last name: ");
            string tempLast = Console.ReadLine();
            Person userPerson = new Person(tempFirst, tempLast);
            Console.WriteLine(defaultPerson.ToString());
            Console.WriteLine(userPerson.ToString());
            defaultPerson.firstName = "Aly";
            userPerson.lastName = "Sanchez";
            Console.WriteLine(defaultPerson.firstName + " " + defaultPerson.lastName);
            Console.WriteLine(userPerson.firstName + " " + userPerson.lastName);
        }
    }
    class Person
    {
        public Person ()
        {
            firstName = "Bob";
            lastName = "Smith";
        }

        public Person (string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public override string ToString ()
        {
            return firstName + " " + lastName;
        }
    }
}
