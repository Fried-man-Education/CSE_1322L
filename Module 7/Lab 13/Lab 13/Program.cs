using System;
using System.IO;
using System.Threading.Tasks;

namespace Lab_13
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("alice.txt");
            string text = sr.ReadToEnd();
            sr.Close();
            int total = 0;
            Console.WriteLine(text.Length);
            Parallel.For(0, text.Length - 2, (i, state) =>
            {
                string nextThree = text[i].ToString() + text[i + 1].ToString() + text[i + 2].ToString();
                if (nextThree.ToLower() == "the")
                {
                    total++;
                }
            });
            Console.WriteLine("There are " + total + " 'the's");
        }
    }
}
