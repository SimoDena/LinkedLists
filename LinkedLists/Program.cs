using System;

namespace LinkedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.AddLast(5);
            list.AddLast(10);
            list.AddLast(15);
            list.AddLast(20);

            //list.AddFirst(5);
            //list.AddFirst(10);
            //list.AddFirst(15);
            //list.AddFirst(20);

            Console.WriteLine(list.IndexOf(15));
            Console.WriteLine(list.Contains(151));

            //list.RemoveFirst();
            //list.RemoveLast();
            list.Reverse();
            Console.ReadKey();
        }
    }
}
