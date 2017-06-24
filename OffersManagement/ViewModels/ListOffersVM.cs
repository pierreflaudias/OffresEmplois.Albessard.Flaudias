using BusinessLayer;
using Model.Entities;
using Model.FluentEntities;
using OffersManagement.Commands;
using OffersManagement.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace OffersManagement.ViewModels
{
    public class ListOffersVM : BaseViewModel
    {

        #region ------Variables------

        private ObservableCollection<DetailOfferVM> _offers = null;
        private ObservableCollection<DetailOfferVM> _allOffers = null;
        private DetailOfferVM _selectedOffer = null;

        private ObservableCollection<Status> _listStatuses;
        private Status _selectedStatus; 

        private CommandHandler _actionAddOffer;
        private CommandHandler _actionDeleteOffer;

        #endregion

        #region ------Constructor------

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


            _listStatuses = new ObservableCollection<Status>();
            List<Status> listStatuses = Manager.Instance.GetAllStatuses();
            foreach(Status stat in listStatuses)
            {
                _listStatuses.Add(stat);
            }
            _allOffers = new ObservableCollection<DetailOfferVM>(_offers);
            if (_listStatuses != null && _listStatuses.Count > 0)
            {
                _selectedStatus = _listStatuses.ElementAt(0);
            }

        }

        #endregion

        #region ------Properties------

        public ObservableCollection<DetailOfferVM> Offers
        {
            get { return _offers; }
            set
            {
                _offers = value;
                OnPropertyChanged("Offers");
            }
        }

        public ObservableCollection<DetailOfferVM> AllOffers
        {
            get { return _allOffers; }
            set
            {
                _allOffers = value;
                OnPropertyChanged("AllOffers");
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


        public ObservableCollection<Status> ListStatuses
        {
            get { return _listStatuses; }
            set
            {
                _listStatuses = value;
                OnPropertyChanged("ListStatuses");
            }
        }

        public Status SelectedStatus
        {
            get { return _selectedStatus; }
            set
            {
                _selectedStatus = value;
                OnPropertyChanged("SelectedStatus");
                OnStatusChanged();
                OnPropertyChanged("Offers");
            }
        }

        #endregion

        #region ------Commands------

        public ICommand ActionAddOffer
        {
            get
            {
                if (_actionAddOffer == null)
                    _actionAddOffer = new CommandHandler(() => this.AddOffer());
                return _actionAddOffer;
            }
        }

        public ICommand ActionDeleteOffer
        {
            get
            {
                if (_actionDeleteOffer == null)
                    _actionDeleteOffer = new CommandHandler(() => this.DeleteOffer());
                return _actionDeleteOffer;
            }
        }

        #endregion

        #region ------Methods------

        public void AddOffer()
        {
            DetailOffer addWindow = new DetailOffer();
            DetailOfferVM newOffer = new DetailOfferVM(new Offer());
            addWindow.DataContext = newOffer;
            Window window = new Window
            {
                Title = "My User Control Dialog",
                Content = addWindow
            };
            window.ShowDialog();
            Offer o = new Offer
            {
                Date = newOffer.Date,
                Description = newOffer.Description,
                Responsible = newOffer.Responsible,
                Salary = newOffer.Salary,
                Status = newOffer.Status,
                StatusId = newOffer.StatusId,
                Title = newOffer.Title
            };
            Manager.Instance.AddOffer(o);
        }

        public void DeleteOffer()
        {
            Manager.Instance.DeleteOffer(SelectedOffer.Id);
            Offers.Remove(SelectedOffer);
        }

        public void OnStatusChanged()
        {
            Offers = new ObservableCollection<DetailOfferVM>();
            List<DetailOfferVM> listTmp = AllOffers.Where(x => x.StatusId == SelectedStatus.Id).ToList();
            foreach(DetailOfferVM o in listTmp)
            {
                Offers.Add(o);
            }
        }

        #endregion


    }
}
