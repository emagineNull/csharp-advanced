using System;
using System.IO;

namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("Input.txt"))
            {
                using (var writer = new StreamWriter("Output.txt"))
                {
                    int counter = 1;

                    while (true)
                    {
                        var line = reader.ReadLine();

                        if (line == null)
                        {
                            break;
                        }

                        line = $"{counter}.{line}";

                        Console.WriteLine(line);
                        counter++;
                    }
                }
            }
        }
    }
}
