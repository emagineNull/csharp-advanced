using System;
using System.IO;
using System.Text.RegularExpressions;

namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("text.txt"))
            {
                using (var writer = new StreamWriter("output.txt"))
                {
                    int lineCounter = 1;
                    while (true)
                    {
                        string line = reader.ReadLine();
                        if (line == null)
                        {
                            break;
                        }

                        int lettersCount = Regex.Matches(line, "[A-Za-z]").Count;
                        int puncCount = Regex.Matches(line, @"[^\w\s]").Count;

                        writer.WriteLine($"Line {lineCounter}: {line} ({lettersCount})({puncCount})");

                        lineCounter++;
                    }
                }
            }
        }
    }
}
