using System;
using System.Threading.Tasks;
using System.Windows;
using System.IO;

namespace FileStreamLee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejemplo1();
            //Ejemplo2();
        }

        static void Ejemplo1()
        {
            string ficheroPrueba = @".\FicheroPrueba\Fichero.txt";

            using FileStream sourceStream = File.Open(ficheroPrueba, FileMode.Open);

            var ouputStream = Console.OpenStandardOutput();

            sourceStream.CopyTo(ouputStream);
        }

        static void Ejemplo2()
        {
            string ficheroPrueba = @".\FicheroPrueba\Fichero.txt";

            using FileStream sourceStream = File.Open(ficheroPrueba, FileMode.Open);

            using StringWriter stringReader = new StringWriter();

            //var ouputStream = Console.OpenStandardOutput();

            //sourceStream.CopyTo(ouputStream);
        }

    }
}
