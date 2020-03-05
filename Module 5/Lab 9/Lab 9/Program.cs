using System;
using System.Collections.Generic;

namespace Lab_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Amount of numbers: ");
            int length = int.Parse(Console.ReadLine());
            ArrayList userInts = new ArrayList(length);
            for (int i = 0; i < length; i++)
            {
                Console.Write(" Number #" + (i + 1) + ": ");
                userInts.AddValue(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Sum: " + SumList(userInts));

            LinkedList<int> userMoreInts = new LinkedList<int>();
            Console.Write("Amount of numbers: ");
            length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                Console.Write(" Number #" + (i + 1) + ": ");
                userMoreInts.AddHead(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Sum: " + SumLinked(userMoreInts));
        }

        static int SumList(ArrayList inputList)
        {
            int sum = 0;
            foreach (int x in inputList.arrayValues) sum += x;
            return sum;
        }

        static int SumLinked(LinkedList<int> inputLinked)
        {
            int sum = 0;
            foreach (int x in inputLinked) sum += x;
            return sum;
        }
    }

    public class LinkedList<T>
    {
        private class Node
        {
            public Node(T t)
            {
                next = null;
                data = t;
            }

            private Node next;
            public Node Next
            {
                get { return next; }
                set { next = value; }
            }

            private T data;

            public T Data
            {
                get { return data; }
                set { data = value; }
            }
        }

        private Node head;
        public LinkedList()
        {
            head = null;
        }
        public void AddHead(T t)
        {
            Node n = new Node(t);
            n.Next = head;
            head = n;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node current = head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }

    public class ArrayList {
        public int[] arrayValues;
        public ArrayList (int length)
        {
            arrayValues = new int[length];
        }

        public void AddValue (int x)
        {
            int[] temp = new int[arrayValues.Length + 1];
            for (int i = 0; i < arrayValues.Length; i++)
            {
                temp[i] = arrayValues[i];
            }
            temp[temp.Length - 1] = x;
            arrayValues = temp;
        }
    }
}
