using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new LinkedList();
            a.CreateLinkedList();
        }
    }

    class LinkList
    {
        Node Head;
    }

    class Node
    {
        public string studentname;
        public Node nextLink;
        public Node prev;
        String nodeName;


    }

    class LinkedList
    {
        Node Head, Orange, Tangerine, Tail;

        public void CreateLinkedList()
        {
            Head = new Node();
            Orange = new Node();
            Tangerine = new Node();
            Tail = Tangerine;

            Head.nextLink = Orange;
            Console.WriteLine("yeahh!!!!");
        }

    }
}