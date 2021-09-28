using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsTraining
{
    public class MyLinkedList
    {
        public ListNode head { get; set; }
        public int count { get; set; }

        /** Initialize your data structure here. */
        public MyLinkedList()
        {
            head = null;
            count = 0;
        }
        /** Get the val of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            if (index <= -1)
            { 
                return -1;
            }
            ListNode temp = head;
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
            newNode.next = head;
            head = newNode;
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            ListNode newNode = new ListNode(val);
            if (head == null || count == 0)
            {
                head = newNode;
            }
        }

        /** Add a node of value val before the index-th node in the linked list. 
         * If index equals to the length of linked list, the node will be appended 
         * to the end of linked list. If index is greater than the length, the node 
         * will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            if (index == count)
            {
                AddAtTail(val);  
            }
            else if (index == 0)
            {
                AddAtHead(val);
            }
            else if (index < count && index > 0)
            {
                ListNode temp = head;
            for (int i = 0;i < index + 1; i++)
                {
                    temp = temp.next;
                }
            }
            else if (index > count)
            {
                return;
            }
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
    
        
        }
    }
}
