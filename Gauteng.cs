 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21493198_HW04.ViewModels
{
    public class Gauteng:Provinces
    {
        private string _TestimonyFromAnEntrepreneur;


        public Gauteng(string testimonyfromanentrepreneur,string population, string povertyrate,string name):base( population, povertyrate,name)
        {
            _TestimonyFromAnEntrepreneur = testimonyfromanentrepreneur;
        }

        public string TestimonyFromAnEntrepreneur
        {
            get { return _TestimonyFromAnEntrepreneur; }
            set { _TestimonyFromAnEntrepreneur = value; }
        }
        public override string Information()
        {
            return "Testimonial.";
        }
    }
}