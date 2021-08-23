using System;
using adv_generics.Traininglist;
using adv_generics.Models;
using System.Collections.Generic;
namespace adv_generics
{
    class Program
    {
        static void Main()
        {
            TaazaaTrainingList obj=new TaazaaTrainingList();
            List<Details> temp= obj.trainingList();
            int len=temp.Count;
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(temp[i].Id+" "+temp[i].pNumber);
            }
        }
    }
}
