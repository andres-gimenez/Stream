using System;
using System.Threading.Tasks;
using System.Windows;
using System.IO;

namespace FileStreamDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string StartDirectory = @".\FicherosPruebas";
            string EndDirectory = @".\FicherosPruebas";

            foreach (string filename in Directory.EnumerateFiles(StartDirectory))
            {
                using FileStream sourceStream = File.Open(filename, FileMode.Open);

                string nombreCopia = Path.GetFileNameWithoutExtension(filename) + ".Copia" + Path.GetExtension(filename);

                using FileStream destinationStream = File.Create(Path.Combine(EndDirectory, nombreCopia));
                
                sourceStream.CopyTo(destinationStream);
            }
        }
    }
}
