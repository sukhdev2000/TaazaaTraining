using System.Collections.Generic;
using adv_generics.Models;
namespace adv_generics.Traininglist
{
    //we have to store phone number and mail id
    public class TaazaaTrainingList
    {
        public List<Details> trainingList()
        {
            List<Details> obj = new List<Details>();
            obj.Add(new Details
            {
                pNumber = 8376092325,
                Id = "dsukhdev2000@gmail.com"
            });
            obj.Add(new Details
            {
                pNumber = 8376092325,
                Id = "siddharth45@gmail.com"
            });
            obj.Add(new Details
            {
                pNumber = 8376092325,
                Id = "dsukhdev2@gmail.com"
            });
            return obj;
        }

    }
}