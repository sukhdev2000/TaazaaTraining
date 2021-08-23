using System.Collections; //it contains already defined classes
using System.Collections.Generic;//providing new approach using generics
using collectionp.Models;

namespace collectionp.Taazaa
{
    public class candidatelist
    {
        public ArrayList candidatedetails()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Sukhdev");
            arrayList.Add(100);
            arrayList.Add("sandeep sir");
            arrayList.Add(102);
            return arrayList;
        }
        public List<candidate> candidatedetail()
        {
            List<candidate> obj = new List<candidate>();
            obj.Add(new candidate
            {
                cid = 101,
                cname = "Sukhdev"
            });
            obj.Add(new candidate
            {
                cid = 102,
                cname = "Sandeep Sir"
            });
            obj.Add(new candidate
            {
                cid = 103,
                cname = "Das Sukhdev"
            });
            return obj;

        }

    }
}