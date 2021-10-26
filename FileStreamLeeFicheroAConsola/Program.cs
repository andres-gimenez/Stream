using System;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Text;

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

            //sourceStream.CopyTo(ouputStream);

            byte[] textSalto = Encoding.UTF8.GetBytes("\n");
            byte[] textH = Encoding.UTF8.GetBytes("H");
            byte[] textAsBytes = Encoding.UTF8.GetBytes("Hola mundo Ҟ");
            byte[] textAsBytes2 = Encoding.Unicode.GetBytes("Hola mundo Ҟ");
            
            ouputStream.Write(textAsBytes);
            ouputStream.WriteByte(10);
            ouputStream.Write(textAsBytes2);
            //ouputStream.Write("\n");

            //ouputStream.Write(new byte[] { 72, 111, 108});
            //ouputStream.WriteByte(111);
            //ouputStream.WriteByte(108);

            /*for (byte i = 30; i < 255; i++)
            {
                ouputStream.WriteByte(i);
            }*/
            //            sourceStream.Flush();*/
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
