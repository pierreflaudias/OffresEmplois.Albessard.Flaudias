using BusinessLayer;
using Model.Entities;
using Model.FluentEntities;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web.Mvc;
using Website.Models;

namespace Website.Controllers
{
    public class HomeController : Controller
    {

        public static List<SelectListItem> GetDropDrown()
        {
            List<SelectListItem> ls = new List<SelectListItem>();
            var lm = Manager.Instance.GetAllStatuses();
            foreach(Status stat in lm)
            {
                ls.Add(new SelectListItem() { Text = stat.Label, Value = stat.Id.ToString() });
            }
            return ls;
        }

        public static void AddNewOfferToDatabase(Offer o)
        {
            o.Date = System.DateTime.Today;
            o.Postulations = new List<Postulation>();
            o.Status = Manager.Instance.GetStatus(o.StatusId);
            Manager.Instance.AddOffer(o);
        }

        public ActionResult Index()
        {
            List<Offer> offers = Manager.Instance.GetAllOffers();
            return View("Index", offers);
        }

        public ActionResult Detail(int id)
        {
            Offer o = Manager.Instance.GetOffer(id);
            return View("Detail",o);
        }

        [HttpPost]
        public ActionResult AddOffer(AddOfferViewModel vm)
        {
            AddNewOfferToDatabase(vm.Offer);
            List<Offer> offers = Manager.Instance.GetAllOffers();
            return View("Index", offers);
        }

        public ActionResult AddOffer()
        {
            Offer o = new Offer();
            var lm = GetDropDrown();
            AddOfferViewModel vm = new AddOfferViewModel
            {
                Offer = o,
                ListStatuses = lm
            };
            return View("AddOffer", vm);
        }


        public ActionResult AddPostulation(int id)
        {
            Employee emp = Manager.Instance.GetAllEmployees().FirstOrDefault();
            Offer off = Manager.Instance.GetOffer(id);
            off.Postulations.Add(new Postulation
            {
                Date = System.DateTime.Today,
                Employee = emp,
                EmployeeId = emp.Id,
                Offer = off,
                OfferId = off.Id,
                Status = off.Status.ToString()
            });
            Manager.Instance.UpdateOffer(off);
            List<Offer> listOffers = Manager.Instance.GetAllOffers();
            return View("Index", listOffers);
        }

        public ActionResult ListPostulations()
        {
            List<Postulation> listPosts = Manager.Instance.GetPostulationsFromEmployee(Manager.Instance.GetAllEmployees().FirstOrDefault());
            return View("ListPostulations", listPosts);
        }

        
        public ActionResult SearchOffers()
        {
            string formValue;
            if (!string.IsNullOrEmpty(Request.QueryString["txtToSearch"].ToString()))
            {
                formValue = Request.QueryString["txtToSearch"].ToString();
                List<Offer> listOffersMatched = Manager.Instance.GetSearchedOffers(formValue);
                return View("Index", listOffersMatched);
            }

            return View("Index", Manager.Instance.GetAllOffers().ToList());
        }
    }
}