using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21493198_HW04.ViewModels
{
    public class FreeState:Provinces
    {
        private string _KindsofJobsWeHaveProvided;

        public FreeState(string kindsofjobswehaveprovided,string population, string povertyrate,string name):base( population,  povertyrate,name)
        {
            _KindsofJobsWeHaveProvided = kindsofjobswehaveprovided;
        }

        public string KindsofJobsWeHaveProvided
        {
            get { return _KindsofJobsWeHaveProvided; }
            set { _KindsofJobsWeHaveProvided = value; }
        }

        public override string Information()
        {
            return "We want to reduce unemployment";
        }
    }
}