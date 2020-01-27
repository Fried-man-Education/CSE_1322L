using System;

namespace Assignment_1B
{
    class Program
    {
        static void Main(string[] args)
        {
            Tests[] students = new Tests[10];
            Console.WriteLine("Enter data for students...");
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Tests();
                Console.WriteLine(" Student # " + (i + 1));
                Console.Write("  first name: ");
                string firstName = Console.ReadLine();
                Console.Write("  last name: ");
                string lastName = Console.ReadLine();
                float[] testScores = new float[students[i].GetTestScores().Length];
                for (int a = 0; a < students[i].GetTestScores().Length; a++)
                {
                    Console.Write("  test #" + (a + 1) + ": ");
                    testScores[a] = float.Parse(Console.ReadLine());
                }
                students[i] = new Tests(firstName, lastName, testScores);
            }
            Console.WriteLine("First name: Last Name: Test 1: Test 2: Test 3: Test 4: Test 5: Average: Letter Grade: ");
            float total = 0;
            foreach (Tests student in students)
            {
                student.CalculateAverage();
                student.DetermineLetter();
                Console.WriteLine(student.GetData());
                total += student.GetAverage();
            }
            Console.WriteLine();
            Console.WriteLine("The Class Average = " + (total / students.Length).ToString("0.00"));
        }
    }

    class Tests
    {
        private string firstName, lastName;
        private float[] testScores = new float[5];
        private float average;
        private char letterGrade;

        public Tests ()
        {
            firstName = null;
            lastName = null;
            average = 0;
            letterGrade = 'F';
        }

        public Tests (string firstName, string lastName, float[] testScores)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.testScores = testScores;
        }

        public void SetFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public string GetFirstName()
        {
            return this.firstName;
        }

        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public string GetLastName()
        {
            return this.lastName;
        }

        public void SetTestScores (float[] testScores)
        {
            this.testScores = testScores;
        }

        public float[] GetTestScores ()
        {
            return this.testScores;
        }

        public void SetIndividualTest(int elementNumber, float testScore)
        {
            this.testScores[elementNumber] = testScore;
        }

        public float GetIndividualTest(int elementNumber)
        {
            return this.testScores[elementNumber];
        }

        public void SetAverage(float average)
        {
            this.average = average;
        }
        public float GetAverage()
        {
            return this.average;
        }

        public void SetLetterGrade(char letterGrade)
        {
            this.letterGrade = letterGrade;
        }
        public char GetLetterGrade()
        {
            return this.letterGrade;
        }

        public void CalculateAverage ()
        {
            float sum = 0;
            foreach (float x in this.testScores)
            {
                sum += x;
            }
            this.average = (sum / this.testScores.Length);
        }

        public void DetermineLetter ()
        {
            if (this.average >= 90)
            {
                this.letterGrade = 'A';
            }else if (this.average >= 80)
            {
                this.letterGrade = 'B';
            }else if (this.average >= 70)
            {
                this.letterGrade = 'C';
            }
            else if (this.average >= 60)
            {
                this.letterGrade = 'D';
            }else
            {
                this.letterGrade = 'F';
            }
        }

        public string GetData ()
        {
            string formattedScores = "";
            foreach (float x in this.testScores)
            {
                formattedScores += " " + x.ToString("0.00");
            }
            return this.firstName + " " + this.lastName + formattedScores + " " + average.ToString("0.00") + " " + letterGrade;
        }
    }
}
