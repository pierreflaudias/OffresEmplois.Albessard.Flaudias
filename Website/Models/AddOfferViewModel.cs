using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Website.Models
{
    public class AddOfferViewModel
    {

        public Offer Offer { get; set; }

        public List<SelectListItem> ListStatuses { get; set; }


    }
}