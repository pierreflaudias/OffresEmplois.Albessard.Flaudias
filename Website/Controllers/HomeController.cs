using BusinessLayer;
using Model.Entities;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Website.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Offer> offers = new List<Offer>
            {
                new Offer
                {
                    Date = System.DateTime.Now,
                    Description = "tretrete",
                    Title = "truc",
                    Id = 3
                },
                new Offer
                {
                    Date = System.DateTime.Now,
                    Description = "tbhuoze",
                    Title = "bidue",
                    Id = 5
                }
            };
            //List<Offer> offers = Manager.Instance.GetAllOffers();
            return View("Index", offers);
        }

        public ActionResult Detail(int id)
        {
            Offer o = new Offer
            {
                Date = System.DateTime.Now,
                Description = "tretrete",
                Title = "truc",
                Id = id
            };
            return View("Detail",o);
        }
    }
}