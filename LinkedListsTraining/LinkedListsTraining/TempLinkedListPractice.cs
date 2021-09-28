using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsTraining
{
    class TempLinkedListPractice
    {
        public class Node
        {
            public int data;
            public Node next;

            public Node(int i)
            {
                data = i;
                next = null;
            }
            public void Print()
            {
                Console.Write($"|{data}|->");
                if (next != null)
                {
                    next.Print();
                }
            }
            public void AddToEnd(int data)
            {
                if (next == null)
                {
                    next = new Node(data);
                }
                else
                {
                    next.AddToEnd(data);
                }
            }
        }

        public class MyList
        {
            public Node headNode;
            public MyList()
            {
                headNode = null;
            }
            public void AddToEnd(int data)
            {
                if (headNode == null)
                {
                    headNode = new Node(data);
                }
                else
                {
                    headNode.AddToEnd(data);
                }
            }
            public void AddToHead(int data)
            {
                if (headNode == null)
                {
                    headNode = new Node(data);
                }
                else
                {
                    Node temp = new Node(data);
                    temp.next = headNode;
                    headNode = temp;
                }
            }
            public void Print()
            {
                if (headNode != null)
                {
                    headNode.Print();
                }
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                MyList list = new MyList();
                list.AddToEnd(3);
                list.AddToEnd(4);
                list.AddToEnd(5);
                list.AddToHead(1);
                list.AddToHead(2);
                list.Print();
            }
        }
    }
}
