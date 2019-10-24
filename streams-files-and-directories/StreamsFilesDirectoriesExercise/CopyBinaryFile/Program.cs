using System;
using System.IO;

namespace CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream stream = File.OpenRead("copyMe.png"))
            {
                using (FileStream writeStream = File.Create("copiedPic.png"))
                {
                    BinaryReader reader = new BinaryReader(stream);
                    BinaryWriter writer = new BinaryWriter(writeStream);

                    // create a buffer to hold the bytes 
                    byte[] buffer = new byte[1024];
                    int bytesRead;

                    // while the read method returns bytes
                    // keep writing them to the output stream
                    while ((bytesRead = stream.Read(buffer, 0, 1024)) > 0)
                    {
                        writeStream.Write(buffer, 0, bytesRead);
                    }
                }
            }
        }
    }
}