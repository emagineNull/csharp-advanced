using System;
using System.IO;
using System.Text;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader(@"Resources/01. Odd Lines/Input.txt"))
            {
                int counter = 0;

                while (true)
                {
                    string line = reader.ReadLine();

                    if (line == null)
                    {
                        break;
                    }

                    if (counter % 2 != 0 || counter == 0)
                    {
                        Console.WriteLine(line);
                    }

                    counter++;
                }
            }

            Console.WriteLine();

            using (var reader = new StreamReader("Text.txt"))
            {
                char[] buffer = new char[16];
                while (true)
                {
                    var total = reader.Read(buffer, 0, buffer.Length);

                    for (int i = 0; i < total; i++)
                    {
                        Console.Write(buffer[i]);
                    }

                    if (total == 0)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine();

            using (var writer = new StreamWriter("sometextfromstream.txt"))
            {
                int count = 1;
                char[] buffer = new char[4] { 'a', 'b', 'c', 'd' };

                while (true)
                {
                    writer.Write(buffer, 0, buffer.Length);
                    writer.Flush();

                    if (count == 10)
                    {
                        break;
                    }

                    count++;
                }
            }

            using (var fs = new FileStream("SomeNewFile.txt", FileMode.OpenOrCreate))
            {
                var buffer = Encoding.UTF8.GetBytes("some text");

                fs.Write(buffer, 0, buffer.Length);


            }
        }
    }
}
