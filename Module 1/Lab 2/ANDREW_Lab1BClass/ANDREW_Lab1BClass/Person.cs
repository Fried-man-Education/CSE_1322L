using System;
using System.Collections.Generic;
using System.Text;

namespace ANDREW_Lab1BClass
{
    class Person
    {
        public Person ()
        {
            firstName = "Bob";
            lastName = "Smith";
        }

        public Person (string inputFirst, string inputLast)
        {
            firstName = inputFirst;
            lastName = inputLast;
        }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public override string ToString ()
        {
            return firstName + " " + lastName;
        }
    }
}
