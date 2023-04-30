using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextWriter1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (TextWriter writer = File.CreateText("C://Users//Emran//Desktop//write//textfile.txt"))
            {


                writer.WriteLine("this is the first line");

            }
            Console.WriteLine("Text data written successfully...");
        }

    }
}
