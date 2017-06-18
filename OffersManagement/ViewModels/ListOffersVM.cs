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
            List<Offer> listOffers = Manager.Instance.GetAllOffers();
            foreach (Offer o in listOffers)
            {
                _offers.Add(new DetailOfferVM(o));
            }

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
                Offer o = new Offer
                {
                    Date = _selectedOffer.Date,
                    Description = _selectedOffer.Description,
                    Postulations = _selectedOffer.Postulations,
                    Responsible = _selectedOffer.Responsible,
                    Salary = _selectedOffer.Salary,
                    Title = _selectedOffer.Title,
                    StatusId = _selectedOffer.StatusId,
                    Id = _selectedOffer.Id
                };
                Manager.Instance.UpdateOffer(o);
                OnPropertyChanged("SelectedOffer");
            }
        }
    }
}
