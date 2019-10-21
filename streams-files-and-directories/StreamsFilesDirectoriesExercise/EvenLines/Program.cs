using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("text.txt"))
            {
                using (var writer = File.CreateText("output.txt"))
                {
                    int counter = 0;

                    while (true)
                    {
                        string line = reader.ReadLine();
                        if (line == null)
                        {
                            break;
                        }

                        line = string.Join(" ", line.Split(' ').Reverse());
                        string replaced = Regex.Replace(line, "[-|,|.|!|?]", "@");

                        if (counter % 2 == 0)
                        {
                            writer.WriteLine(replaced);
                        }

                        counter++;
                    }
                }
            }
        }
    }
}
