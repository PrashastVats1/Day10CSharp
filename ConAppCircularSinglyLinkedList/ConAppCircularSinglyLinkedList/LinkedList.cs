using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppCircularSinglyLinkedList
{
    public class LinkedList
    {
        public Node head;
        public LinkedList()
        {
            head = null;
        }
        public void PrintSinglyCircularList()
        {
            Node temp = new Node();
            temp = this.head;
            if (temp != null)
            {
                Console.WriteLine("The list Contains");
                while (temp != null)
                {
                    Console.WriteLine(temp.data + " ");
                    temp = temp.next;
                    if (temp == this.head)
                    { break; }

                }
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("This Linked list is empty");
            }
        }
    }
}
