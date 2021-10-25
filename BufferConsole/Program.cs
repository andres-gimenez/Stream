using System;

namespace BufferConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var ouputStream = Console.OpenStandardOutput();

            using var inputStream = Console.OpenStandardInput();

            var buffer = new byte[4096];
            int count;
            while((count = inputStream.Read(buffer)) > 0)
            {
                ouputStream.Write(buffer, 0, count);
            }
        }
    }
}
