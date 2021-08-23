using System;
using day6.Collections;
namespace day6
{
    class Program
    {
        static void Main(string[] args)
        {
            var cList=new Candidates();
            //cList.addCandidatesNames();
            string Name=cList.AddCandidatesNames();
            Console.WriteLine(Name);
            string Name1=cList.AddCandidatesNames2();
            Console.WriteLine(Name1);
        }
    }
}
