using BusinessLayer;
using Model.Entities;
using Model.FluentEntities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OffersManagement.ViewModels
{
    public class ListOffersVM : BaseViewModel
    {
        private ObservableCollection<DetailOfferVM> _offers = null;
        private DetailOfferVM _selectedOffer = null;

        public ListOffersVM()
        {
            _offers = new ObservableCollection<DetailOfferVM>();
            foreach (Offer o in Manager.Instance.GetAllOffers())
            {
                _offers.Add(new DetailOfferVM(o));
            }
           // Offer a = new Offer()
           // {
           //     Title = "offre a",
           //     Date = DateTime.Today,
           //     Description = "description fsgdhfsefk",
           //     Responsible = "mr toto",
           //     Salary = 15000,
           //     Status = new Status { Id = 1, Label = "statustest" },
           //     Postulations = new List<Postulation>()
           // };
           //a.Postulations.Add(new Postulation
           // {
           //     Date = DateTime.Today,
           //     Employee = new Employee
           //     {
           //         FirstName = "totot",
           //         Name = "tructruc"
           //     },
           //     Offer = a
           // });
           // Offer b = new Offer()
           // {
           //     Title = "offre b",
           //     Date = DateTime.Today,
           //     Description = "description hfjzgzehuezhzuohzk",
           //     Responsible = "mr tata",
           //     Salary = 30000,
           //     Status = new Status { Id = 2, Label = "ier" },
           //     Postulations = new List<Postulation>()
           // };
           // b.Postulations.Add(new Postulation
           // {
           //     Date = DateTime.Today,
           //     Employee = new Employee
           //     {
           //         FirstName = "qsdf",
           //         Name = "aaaaaaazerty"
           //     },
           //     Offer = b
           // });
           // b.Postulations.Add(new Postulation
           // {
           //     Date = DateTime.Today,
           //     Employee = new Employee
           //     {
           //         FirstName = "ygherieorg",
           //         Name = "hgeruizoghuieroghiuoer"
           //     },
           //     Offer = b
           // });
            //_offers = new ObservableCollection<DetailOfferVM>();
            //Offers.Add(new DetailOfferVM(a));
            //Offers.Add(new DetailOfferVM(b));


            if (_offers != null && _offers.Count > 0)
            {
                _selectedOffer = _offers.ElementAt(0);
            }
        }

        public ObservableCollection<DetailOfferVM> Offers
        {
            get { return _offers; }
            set
            {
                _offers = value;
                OnPropertyChanged("Offers");
            }
        }

        public DetailOfferVM SelectedOffer
        {
            get { return _selectedOffer; }
            set
            {
                _selectedOffer = value;
                OnPropertyChanged("SelectedOffer");
            }
        }
    }
}
