using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new CoolLinkedList();

            linkedList.AddHead(5);
            linkedList.AddHead(10);
            linkedList.AddHead(15);

            // 15 <-> 10 <-> 5

            Console.WriteLine((int)linkedList.Head == 15);
            Console.WriteLine((int)linkedList.Tail == 5);
            Console.WriteLine(linkedList.Count == 3);

            linkedList.AddTail(20);
            linkedList.AddTail(25);

            // 15 <-> 10 <-> 5 <-> 20 <-> 25

            linkedList.ForEach(Console.WriteLine, true);

            var arr = linkedList.ToArray();

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(linkedList.Count == 5);
            Console.WriteLine((int)linkedList.Head == 15);
            Console.WriteLine((int)linkedList.Tail == 25);

            Console.WriteLine((int)linkedList.RemoveHead() == 15);
            Console.WriteLine((int)linkedList.RemoveHead() == 10);
            Console.WriteLine((int)linkedList.Head == 5);
            Console.WriteLine(linkedList.Count == 3);

            // 5 <-> 20 <-> 25

            Console.WriteLine((int)linkedList.RemoveTail() == 25);
            Console.WriteLine((int)linkedList.RemoveTail() == 20);
            Console.WriteLine((int)linkedList.RemoveTail() == 5);
            Console.WriteLine(linkedList.Count == 0);

            try
            {
                Console.WriteLine(linkedList.Head);
                Console.WriteLine(false);
            }
            catch (InvalidCastException)
            {
                Console.WriteLine(true);
            }

            var linkedList2 = new CoolLinkedList();

            linkedList2.AddTail(5);
            linkedList2.AddTail(10);
            linkedList2.AddTail(5);
            linkedList2.AddTail(20);
            linkedList2.AddTail(5);

            linkedList2.Remove(5);

            Console.WriteLine((int)linkedList2.Head == 10);
            Console.WriteLine((int)linkedList2.Tail == 20);
            Console.WriteLine(linkedList2.Contains(10));
            Console.WriteLine(linkedList2.Contains(20));
            Console.WriteLine(linkedList2.Contains(5) == false);
            Console.WriteLine(linkedList2.Count == 2);
        }
    }
}
