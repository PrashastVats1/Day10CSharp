using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConAppCircularDoublyLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            Node first = new Node()
            {
                data = 12,
                next = null,
                prev = null
            };
            linkedList.head = first;
            first.next = linkedList.head;
            linkedList.head.prev = first;
            Node second = new Node()
            {
                data = 20,
                next = null,
                prev = first
            };
            first.next = second;
            second.next = linkedList.head;
            linkedList.head.prev = second;
            Node third = new Node()
            {
                data = 30,
                next = null,
                prev = second
            };
            second.next = third;
            third.next = linkedList.head;
            linkedList.head.prev = third;
            linkedList.PrintDoublyCircularList();
            Console.ReadKey();

        }
    }
}
