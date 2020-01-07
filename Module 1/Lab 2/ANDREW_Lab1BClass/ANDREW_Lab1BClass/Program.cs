using System;

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
}
