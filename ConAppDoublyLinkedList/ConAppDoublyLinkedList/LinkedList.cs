using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDoublyLinkedList
{
    public class LinkedList
    {
        public Node head;
        public LinkedList()
        {
            head = null;
        }
        public void InsertAtEnd(int newElement)
        {
            Node newNode = new Node();
            newNode.data = newElement;
            newNode.next = null;
            newNode.prev = null;
            if(head == null)
            {
                head = newNode;
            }
            else
            {
                //Node temp = head;
                Node temp = new Node();
                temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
                newNode.prev = temp;
            }
        }
        public void PrintLList()
        {
            Node temp = new Node();
            temp = this.head;
            if (temp != null)
            {
                Console.WriteLine("The list contains");
                while (temp != null)
                {
                    Console.WriteLine(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("The linked list is empty");
            }
        }
    }
}
