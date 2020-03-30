using System;

namespace Assignment5
{
    public class LinkedList<Type>
    {
        private Node<Type> first;

        public LinkedList()
        {
            this.first = null;
        }

        public int Add(Type data)
        {
            int position = 0;
            Node<Type> curr = this.first;
            while (curr != null)
            {
                if (curr.dataGet.ToString() == data.ToString())
                {
                    curr.countAdaptable++;
                    return position;
                }else if (curr.nextAdaptable == null)
                {
                    curr.nextAdaptable = new Node<Type>(data);
                    return ++position;
                }
                curr = curr.nextAdaptable;
                position++;
            }
            this.first = new Node<Type>(data);
            return position;
        }

        public int GetCount(Type data)
        {
            Node<Type> curr = first;
            while (curr != null)
            {
                if (curr.dataGet.ToString() == data.ToString())
                {
                    return curr.countAdaptable;
                }
                curr = curr.nextAdaptable;
            }
            return 0;
        }

        public String GetReport()
        {
            if (first == null)
            {
                return "The list is empty";
            }
            Node<Type> curr = first;
            string total = "Contents of the list: \n";
            while (curr != null)
            {
                total += curr.dataGet.ToString() + " with count " + curr.countAdaptable + "\n";
                curr = curr.nextAdaptable;
            }
            return total;
        }

        //Simple Node Class
        class Node<E>
        {
            E data;
            Node<E> next;
            int count;

            public Node(E data)
            {
                this.data = data;
                this.next = null;
                this.count = 1;
            }

            public Node<E> nextAdaptable 
            {
                get { return next; }
                set { this.next = value; }
            }

            public int countAdaptable
            {
                get { return count; }
                set { count = value; }
            }

            public E dataGet
            {
                get { return data; }
            }
        }
    }
}
