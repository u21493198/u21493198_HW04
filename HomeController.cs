using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u21493198_HW04.ViewModels;

namespace u21493198_HW04.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
          
            return View();
        }

        public ActionResult Contact()
        {

            return View();
        }

        public ActionResult VolunteerForm()
        {
            return View();
        }

       

        public ActionResult SponsorAChildForm()
        {
            return View();
        }

        public ActionResult PostAJobForm()
        {

            return View();
        }

        public ActionResult DonateForm()
        {
            return View();
        }

        private List<Gauteng> GetData()
        {
            List<Gauteng> gauteng = new List<Gauteng>();
            Gauteng info = new Gauteng("My name is Anele Dlomo and  I own three businesses which have about 248 employees.I used to dream of having my own business one day and my wish came true all beacause of the support I got from SiyabongaAfrica.They helped me believe in myself and they also believed in me.They gave me money to start my first business and helped me train my employees.When my business started doing well I decided to open two more businesses and SiyabongaAfrica insisted on helping me with the other bussiness too.All thanks to SiyabongaAfrica I have now employeed a lot of the community members who used to be jobless.SiyabongaAfrica is really changing lives","approximately 16.1 million" ,"44.1%","Gauteng");
            gauteng.Add(info);
            return gauteng;
        }

        private List<KwaZuluNatal> Data()
        {
            List<KwaZuluNatal> kzn = new List<KwaZuluNatal>();
            KwaZuluNatal infor = new KwaZuluNatal(78000,"approximately 11.5 million","42.5%","KwaZuluNatal");
            kzn.Add(infor);
            return kzn;
        }

        private List<FreeState> DataGet()
        {
            List<FreeState> freestate = new List<FreeState>();
            FreeState informa = new FreeState("We have provided our unemployed community members with:Teaching jobs,Cooking jobs,Electrician jobs,Nursing jobs,Farmer jobs,Cleaner jobs,Waitress and Waiter jobs and many other more kinds of jobs","approximately 2.9 million","41.7%","FreeState");
            freestate.Add(informa);
            return freestate;
        }

 

        public ActionResult Gauteng()
        {
            List<Gauteng> gaut = GetData();
            return View(gaut);
        }

        public ActionResult Freestate()
        {
            List<FreeState> kzn = DataGet();
            return View(kzn);
        }

        public ActionResult KwaZuluNatal()
        {
            List<KwaZuluNatal> kzn = Data();
            return View(kzn);
        }
    }
}