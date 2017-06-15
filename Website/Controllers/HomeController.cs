using BusinessLayer;
using Model.Entities;
using Model.FluentEntities;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Website.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Offer> offers = Manager.Instance.GetAllOffers();

            return View("Index", offers);
        }

        public ActionResult Detail(int id)
        {
            //Offer o = new Offer
            //{
            //    Date = System.DateTime.Now,
            //    Description = "tretrete",
            //    Title = "truc",
            //    Id = id
            //};
            Offer o = Manager.Instance.GetOffer(id);
            return View("Detail",o);
        }

        public ActionResult AddOffer()
        {
            Offer o = new Offer();
            return View("AddOffer", o);
        }
    }
}