using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppSinglyLlinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            Node first = new Node()
            {
                data = 12,
                next = null
            };
            linkedList.head = first;
            Node second = new Node()
            {
                data = 20,
                next = null
            };
            first.next = second;
            Node third = new Node()
            {
                data = 30,
                next = null
            };
            second.next = third;
            linkedList.PrintLList();
            Console.ReadKey();
        }
    }
}
