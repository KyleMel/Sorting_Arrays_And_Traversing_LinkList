using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsTraining
{
    public class MyLinkedList
    {
        public ListNode Head { get; set; }
        public ListNode Tail { get; set; }
        public int Count { get; set; }

        /** Initialize your data structure here. */
        public MyLinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        /** Get the val of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            if (index > Count) return -1;
            ListNode temp = Head;
            for (int i = 0; i < index; i++)
            {
                temp = temp.next;
            }
            return temp.val;
        }

        /** Add a node of val val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            ListNode newNode = new ListNode(val);
            newNode.next = Head;
            Head = newNode;
            Count++;

            if (Head.next == null)
            {
                Tail = Head;
            }
        }

        /** Append a node of val val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            ListNode newNode = new ListNode(val);
            if (Tail != null)
            {
                Tail.next = newNode;
            }
            else if (Tail == null || Count == 0)
            {
                Head = newNode;
            }
            Tail = newNode;
            Count++;
        }

        /** Add a node of value val before the index-th node in the linked list. 
         * If index equals to the length of linked list, the node will be appended 
         * to the end of linked list. If index is greater than the length, the node 
         * will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            if (index < 0 || index > Count) return;
            if (index == 0)
            {
                AddAtHead(val);  
            }
            else if (index == Count)
            {
                AddAtTail(val);
            }
            else
            {
                ListNode temp = Head;
                for (int i = 0; i < index - 1; i++)
                {
                    temp = temp.next;
                }
                ListNode n = new ListNode(val);
                ListNode save = temp;
                temp = temp.next;
                save.next = n;
                n.next = temp;
                Count++;
            }
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            if (Count == 0 || index < 0 || index >= Count)
            {
                return;
            }
            if (index == 0)
            {
                Head = Head.next;
                Count--;
                if (Count == 0)
                {
                    Tail = null;
                }
            }
            else
            {
                ListNode newNode = Head;
                for (int i = 0; i < index - 1; i++)
                {
                    newNode = newNode.next;
                }
                newNode.next = newNode.next.next;
                Count--;
                if (newNode.next == null)
                {
                    Tail = newNode;
                }

            }
        }
    }
}
