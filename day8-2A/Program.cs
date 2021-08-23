using System;
using day8_2A.FileHandling;
namespace day8_2A
{
    class Program
    {
        static void Main(string[] args)
        {
            FileHandler filehandler=new FileHandler();
            filehandler.WriteToFile("I am Sukhdev");
            filehandler.ReadFromFile();
        }
    }
}
