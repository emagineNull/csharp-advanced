using System;
using System.Collections.Generic;
using System.Linq;

namespace Socks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] leftSocks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] rightSocks = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var leftSocksStack = new Stack<int>(leftSocks);
            var rightSocksQueue = new Queue<int>(rightSocks);

            var sets = new List<int>();

            while (leftSocksStack.Any() && rightSocksQueue.Any())
            {
                int currentLeftSock = leftSocksStack.Peek();
                int currentRightSock = rightSocksQueue.Peek();

                if (currentLeftSock > currentRightSock)
                {
                    sets.Add(currentLeftSock + currentRightSock);

                    leftSocksStack.Pop();
                    rightSocksQueue.Dequeue();
                }
                else if (currentRightSock > currentLeftSock)
                {
                    leftSocksStack.Pop();
                }
                else if (currentRightSock == currentLeftSock)
                {
                    rightSocksQueue.Dequeue();
                    int temp = leftSocksStack.Pop() + 1;
                    leftSocksStack.Push(temp);
                }
            }

            Console.WriteLine(sets.Max());
            Console.WriteLine(string.Join(" ", sets));
        }
    }
}
