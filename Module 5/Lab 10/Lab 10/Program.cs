using System;
using System.Collections;

namespace Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack urmomlmao = new Stack();
            urmomlmao.Push("Street");
            urmomlmao.Pop();
            urmomlmao.Peek();

            Queue urmomlmaoPartTwo = new Queue();
            urmomlmaoPartTwo.Enqueue("Calle");
            urmomlmaoPartTwo.Dequeue();
            urmomlmaoPartTwo.Peek();
        }
    }

    class Stack {

        ArrayList theStack;

        public Stack ()
        {
            theStack = new ArrayList() { "Hello", "Goodbye", "Zombies" };
            Console.Write("Initial contents of the stack: ");
            printValues();
        }

        public void Pop()
        {
            Console.Write("Contents before removing an item: ");
            printValues();
            Console.WriteLine("Removed: \"" + theStack[theStack.Count - 1] + "\"\n");
            theStack.RemoveAt(theStack.Count - 1);
            Console.Write("Contents after removing an item: ");
            printValues();

        }

        public void Push(string input)
        {
            Console.Write("Contents before adding another item: ");
            printValues();
            theStack.Add(input);
            Console.WriteLine("Added: \"" + input + "\"\n");
            Console.Write("Contents after adding another item: ");
            printValues();
        }

        public void Peek()
        {
            Console.Write("Contents before peeking a value from the queue: ");
            printValues();
            Console.WriteLine("Peeked: \"" + theStack[theStack.Count - 1].ToString() + "\"\n");
            Console.Write("Contents after peeking a value from the queue: ");
            printValues();
        }

        public void printValues ()
        {
            for (int i = 0; i < theStack.Count; i++)
            {
                Console.Write("\"" + theStack[i] + "\"");
                if (i != theStack.Count - 1)
                {
                    Console.Write(", ");
                }else
                {
                    Console.WriteLine("\n");
                }
            }
        }
    }

    class Queue
    {

        ArrayList theQueue;

        public Queue()
        {
            theQueue = new ArrayList() { "Hola", "Hast la Vista", "Zombis" };
            Console.Write("Initial contents of the stack: ");
            printValues();
        }

        public void Dequeue()
        {
            Console.Write("Contents before removing an item: ");
            printValues();
            Console.WriteLine("Removed: \"" + theQueue[0] + "\"\n");
            theQueue.RemoveAt(0);
            Console.Write("Contents after removing an item: ");
            printValues();

        }

        public void Enqueue(string input)
        {
            Console.Write("Contents before adding another item: ");
            printValues();
            theQueue.Add(input);
            Console.WriteLine("Added: \"" + input + "\"\n");
            Console.Write("Contents after adding another item: ");
            printValues();
        }

        public void Peek()
        {
            Console.Write("Contents before peeking a value from the queue: ");
            printValues();
            Console.WriteLine("Peeked: \"" + theQueue[0].ToString() + "\"\n");
            Console.Write("Contents after peeking a value from the queue: ");
            printValues();
        }

        public void printValues()
        {
            for (int i = 0; i < theQueue.Count; i++)
            {
                Console.Write("\"" + theQueue[i] + "\"");
                if (i != theQueue.Count - 1)
                {
                    Console.Write(", ");
                }
                else
                {
                    Console.WriteLine("\n");
                }
            }
        }
    }
}
