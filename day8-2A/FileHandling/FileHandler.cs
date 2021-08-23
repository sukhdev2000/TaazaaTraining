using System;
using System.IO;
namespace day8_2A.FileHandling
{
    public class FileHandler
    {
        public void WriteToFile(string name)
        {
        FileStream f=new FileStream("training.txt",FileMode.Create);
        StreamWriter s=new StreamWriter(f);
        s.WriteLine(name);
        s.Close();
        f.Close();
        }

        public void ReadFromFile()
        {
            FileStream fileStream=new FileStream("training.txt",FileMode.Open);
            StreamReader reader=new StreamReader(fileStream);
            string fileData=reader.ReadLine();
            Console.WriteLine(fileData);
            reader.Close();
        }
    }
}