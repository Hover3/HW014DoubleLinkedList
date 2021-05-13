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


        }
    }
}
