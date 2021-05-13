using System;
using HW014.Implementations;

namespace HW014
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HW14 Double linked list");
            MyDoubleLinkedList myList = new MyDoubleLinkedList();
            Console.WriteLine($"List item count: {myList.count}");
            Console.WriteLine($"Adding item 0 at the begin");
            myList.AddFirst(0);

            Console.WriteLine($"Adding item 10 at the end");
            myList.AddLast(10);



        }
    }
}
