using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21493198_HW04.ViewModels
{
    public class KwaZuluNatal:Provinces
    {
        private int _NumberofFoodParcelsHandedInToThePoor;

        public KwaZuluNatal(int numberoffoodparcelshandedintothepoor, string population,string povertyrate,string name) :base(population, povertyrate,name)
        {
            _NumberofFoodParcelsHandedInToThePoor = numberoffoodparcelshandedintothepoor;
        }

        public int NumberofFoodParcelsHandedInToThePoor
        {
            get { return _NumberofFoodParcelsHandedInToThePoor; }
            set { _NumberofFoodParcelsHandedInToThePoor = value; }
        }

        public override string Information()
        {
            return "Number of food parcels handed in to the poor";
        }
    }
}