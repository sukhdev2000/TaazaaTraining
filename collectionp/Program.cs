using System;
using collectionp.Taazaa;
using collectionp.Models;
using System.Collections;
namespace collectionp
{
    class Program
    {
        static void Main()
        {
           var obj =new candidatelist();
           ArrayList arrayList=obj.candidatedetails(); 
           int count=arrayList.Count;
           for(int i=0;i<count;i++)
           {
               System.Console.WriteLine(arrayList[i]);
           } 
           var objlist =new candidatelist();
           var list=objlist.candidatedetail(); 
           int count1=list.Count;
           for(int i=0;i<count1;i++)
           {
               Console.WriteLine(list[i].cid+" "+list[i].cname);
           }
        }
    }
}
