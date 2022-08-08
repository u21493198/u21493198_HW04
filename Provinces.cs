using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21493198_HW04.ViewModels
{
    public abstract class Provinces
    {
        private string _Name;
        private string _Population;
        private string _PovertyRate;


        public Provinces(string population, string povertyrate,string name)
        {
            _Population = population;
            _PovertyRate = povertyrate;
            _Name = name;
        }


        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Population
        {
            get { return _Population; }
            set { _Population = value; }
        }

        public string PovertyRate
        {
            get { return _PovertyRate; }
            set { _PovertyRate = value; }
        }
        public virtual string getInfo()
        {
            return Name+" "+"has a population of"+" " + Population +"  " +"and a poverty rate of" +"  "+ PovertyRate;
        }

        public abstract string Information();
    }
}