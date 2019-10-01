using System;
using System.Collections.Generic;
using System.Linq;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ");

            var songs = new Queue<string>(input);

            var command = Console.ReadLine().Split();

            while (true)
            {
                if (command[0] == "Play")
                {
                    songs.Dequeue();
                }
                if (command[0] == "Add")
                {
                    var song = string.Empty;

                    for (int i = 1; i < command.Length; i++)
                    {
                        song += command[i] + " ";
                    }

                    song = song.TrimEnd();

                    if (!songs.Contains(song))
                    {
                        songs.Enqueue(song);
                    }
                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                }
                if (command[0] == "Show")
                {
                    Console.WriteLine($"{string.Join(", ", songs)}");
                }

                if (songs.Any())
                {
                    command = Console.ReadLine().Split();
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
