using System;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person defaultPerson = new Person();
            Console.WriteLine(defaultPerson.toString());
            Person.Student defaultStudent = new Person.Student();
            Console.WriteLine(defaultStudent.toString());
            Person.Employee defaultEmployee = new Person.Employee();
            Console.WriteLine(defaultEmployee.toString());
            Person.Employee.Faculty defaultFaculty = new Person.Employee.Faculty();
            Console.WriteLine(defaultFaculty.toString());
            Person.Employee.Staff defaultStaff = new Person.Employee.Staff();
            Console.WriteLine(defaultStaff.toString());
        }
    }

    class Person
    {
        string name, address, phoneNumber, email;
        public Person ()
        {
            name = "John Smith";
            address = "1600 Pennsylvania Ave NW, Washington, DC 20500";
            phoneNumber = "(404) 123-4567";
            email = "johnsmith@gmail.com";
        }
        public string toString ()
        {
            return (
                "Default " + this.GetType().Name + ":\n" +
                " name = " + name + "\n" +
                " address = " + address + "\n" +
                " phoneNumber = " + phoneNumber + "\n" +
                " email = " + email
            );
        }
        public class Student : Person
        {
            string classStatus;
            public Student ()
            {
                classStatus = "Freshman";
            }

            public new string toString ()
            {
                return (
                    "Default " + this.GetType().Name + ":\n" +
                    " name = " + name + "\n" +
                    " address = " + address + "\n" +
                    " phoneNumber = " + phoneNumber + "\n" +
                    " email = " + email + "\n" +
                    " classStatus = " + classStatus
                );
            }
        }

        public class Employee : Person
        {
            string office, salary;
            MyDate dateHired;
            public Employee ()
            {
                office = "Burrus Building, Room #214";
                salary = "$200,000";
                dateHired = new MyDate("1969", "11", "7");
            }
            public new string toString()
            {
                return (
                    "Default " + this.GetType().Name + ":\n" +
                    " name = " + name + "\n" +
                    " address = " + address + "\n" +
                    " phoneNumber = " + phoneNumber + "\n" +
                    " email = " + email + "\n" +
                    " office = " + office + "\n" +
                    " salary = " + salary + "\n" +
                    " dateHired = " + dateHired.toString()
                );
            }
            public class Faculty : Employee
            {
                string officeHours;
                string rank;
                public Faculty ()
                {
                    officeHours = "9am to 9pm";
                    rank = "1101 Professor";
                }
                public new string toString ()
                {
                    return (
                        "Default " + this.GetType().Name + ":\n" +
                        " name = " + name + "\n" +
                        " address = " + address + "\n" +
                        " phoneNumber = " + phoneNumber + "\n" +
                        " email = " + email + "\n" +
                        " office = " + office + "\n" +
                        " salary = " + salary + "\n" +
                        " dateHired = " + dateHired.toString() + "\n" +
                        " officeHours = " + officeHours + "\n" +
                        " rank = " + rank
                    );
                }
            }

            public class Staff : Employee
            {
                string title;
                public Staff ()
                {
                    title = "Head of Security";
                }
                public new string toString()
                {
                    return (
                        "Default " + this.GetType().Name + ":\n" +
                        " name = " + name + "\n" +
                        " address = " + address + "\n" +
                        " phoneNumber = " + phoneNumber + "\n" +
                        " email = " + email + "\n" +
                        " office = " + office + "\n" +
                        " salary = " + salary + "\n" +
                        " dateHired = " + dateHired.toString() + "\n" +
                        " title = " + title
                    );
                }
            }
        }
    }

    class MyDate
    {
        string year;
        string month;
        string day;
        public MyDate (string Year, string Month, string Day)
        {
            year = Year;
            month = Month;
            day = Day;
        }
        public string toString ()
        {
            return month + "/" + day + "/" + year;
        }
    }
}
