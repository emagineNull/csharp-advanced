using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, int>();
            using (var reader = new StreamReader("words.txt"))
            {
                string[] words = reader.ReadToEnd().Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < words.Length; i++)
                {
                    using (var reader2 = new StreamReader("text.txt"))
                    {
                        string[] text = reader2.ReadToEnd().Split(new[] { ' ', '-', '.', ',', '!', '.' }, StringSplitOptions.RemoveEmptyEntries);

                        for (int j = 0; j < text.Length; j++)
                        {
                            if (text[j].ToLower() == words[i])
                            {
                                if (!dict.ContainsKey(words[i]))
                                {
                                    dict.Add(words[i], 0);
                                }

                                dict[words[i]]++;
                            }
                        }
                    }
                }
            }

            using (var writer = new StreamWriter("actualResult.txt"))
            {
                foreach (var kvp in dict.OrderByDescending(w => w.Value))
                {
                    writer.WriteLine($"{kvp.Key} - {kvp.Value}");
                }
            }
        }
    }
}