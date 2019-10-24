using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory = @"C:\Users\User\Desktop\stuff\C# Advanced - January 2019\Streams, Files and Directories\StreamsFilesDirectoriesExercise\DirectoryTraversal";
            SortedDictionary<string, Dictionary<string, double>> extensions = new SortedDictionary<string, Dictionary<string, double>>();
            DirectoryInfo directorySelected = new DirectoryInfo(directory);
            FileInfo[] whole = directorySelected.GetFiles();

            GetFileExtensions(extensions, whole);

            GroupAndWrite(extensions);

        }
        static void GroupAndWrite(SortedDictionary<string, Dictionary<string, double>> extensions)
        {
            var orderedExtension = extensions.OrderByDescending(p => p.Value.Count).ThenBy(ext => ext.Key);
            using (StreamWriter destination = new StreamWriter(@"C:\Users\User\Desktop\text.txt"))
            {
                foreach (var item in orderedExtension)
                {
                    destination.WriteLine(item.Key);
                    var orderedDic = item.Value.OrderBy(f => f.Value);
                    foreach (var output in orderedDic)
                    {
                        destination.WriteLine($"{output.Key}{output.Value / 1024:f3}kb");
                    }
                }
            }
        }
        static void GetFileExtensions(SortedDictionary<string, Dictionary<string, double>> extensions, FileInfo[] files)
        {
            foreach (var n in files)
            {
                if (!extensions.ContainsKey(n.Extension))
                {
                    extensions.Add(n.Extension, new Dictionary<string, double>
                                    {{string.Format("--{0} - ", n.Name), n.Length}});
                }
                else
                {
                    extensions[n.Extension].Add(string.Format("--{0} - ", n.Name), n.Length);
                }
            }
        }
    }
}