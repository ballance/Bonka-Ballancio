using System;
using System.Web.Mvc;
using BonkaBallancio.Models.ViewModels;

namespace BonkaBallancio.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(string Id)
        {
            ProfileViewModel profile = null;
            switch (Id)
            {
                case "Ballancio":
                    {
                        profile = BallancioProfile();
                    break;
                    }
                case "Bonka":
                {
                    profile = BonkaProfile();
                    break;
                }
                default:
                    throw new NotImplementedException("Nobody by that name on the ticket");
            }
            return View(profile);
        }

         public ActionResult Bonka()
        {
             return View(BonkaProfile());
             }

         public ActionResult Ballancio()
         {
             return View(BallancioProfile());
         }

        public ProfileViewModel BonkaProfile()
        {
            var pro = new ProfileViewModel()
            {
                Name = "Borka",
                Bio = "Wanders the earth.",
                HomeTown = "Elkton, KY"
            };

            return pro;
        }
        public ProfileViewModel BallancioProfile()
        {
            var pro = new ProfileViewModel()
            {
                Name = "Ballancio",
                Bio = "His shoes fell off.",
                HomeTown = "Greensboro, NC"
            };

            return pro;
        }
    }
}