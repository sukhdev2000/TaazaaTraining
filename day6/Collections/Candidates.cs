using System;
using System.Collections;
using System.Collections.Generic;
namespace day6.Collections
{
    public class Candidates
    {
        public string AddCandidatesNames() //camel case
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Sukhdev");//boxing because value type is converting into reference type
            arrayList.Add("Rakesh");
            arrayList.Add("Ankur");
            arrayList.Add("Anil");
            string Name = (string)arrayList[0];  //unboxing because again we converting reference into value type
            //Console.WriteLine(Name);
            return Name;
        }
        public string AddCandidatesNames2() //camel case
        {
            List<string> obj = new List<string>();  //we are strongly typing here
            obj.Add("Sukhdev");
            obj.Add("Das Sukhdev");
            /*     bool temp= obj.Contains("Sukhdev");
                if(temp==false)
                {
                    Console.WriteLine("Name not found");
                } */
            if (obj.Contains("sukhdev"))
            {
                Console.WriteLine("Name found");
            }
            else
            {
                Console.WriteLine("Name not found");
            }
            string Name = obj[1];//find the difference between 15 and 24
            return Name;


        }
    }
}