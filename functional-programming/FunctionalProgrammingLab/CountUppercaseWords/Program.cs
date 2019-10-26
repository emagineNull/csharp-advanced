using System;
using System.Linq;

namespace CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kenov
            //Console.ReadLine()
            //    .Split()
            //    .Where(w => char.IsUpper(w[0]))
            //    .ToList()
            //    .ForEach(Console.WriteLine); 

            Func<string, bool> checker = w => w[0] == w.ToUpper()[0];

            var words = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Where(checker)
                .ToArray();

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
