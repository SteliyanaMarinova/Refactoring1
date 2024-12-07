using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha
{
    public class LinkedList
    {
        public Node Head { get; set; }

        public void Append(int value)
        {
            Node newNode = new Node(value);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public void PrintList()
        {
            Node current = Head;
            while (current != null)
            {
                Console.Write(current.Value + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }

        public LinkedList SplitList(string type)
        {
            LinkedList newList = new LinkedList();
            Node current = Head;
            while (current != null)
            {
                if (type == "even" && current.Value % 2 == 0)
                {
                    newList.Append(current.Value);
                }
                else if (type == "odd" && current.Value % 2 != 0)
                {
                    newList.Append(current.Value);
                }
                current = current.Next;
            }
            return newList;
        }
    }

    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int value)
        {
            Value = value;
            Next = null;
        }
    }
}
