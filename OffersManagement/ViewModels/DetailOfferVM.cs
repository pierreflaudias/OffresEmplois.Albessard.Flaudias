using Model.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OffersManagement.ViewModels
{
    public class DetailOfferVM : BaseViewModel
    {
        private string _title;
        private float _salary;
        private string _responsible;
        private DateTime _date;
        private string _description;
        private string _status;
        private ObservableCollection<Postulation> _postulations;

        public DetailOfferVM(Offer o)
        {
            _title = o.Title;
            _salary = o.Salary;
            _responsible = o.Responsible;
            _date = o.Date;
            _description = o.Description;
            _status = o.Status.Label;
            _postulations = new ObservableCollection<Postulation>(o.Postulations);
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public float Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public string Responsible
        {
            get { return _responsible; }
            set { _responsible = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public ObservableCollection<Postulation> Postulations
        {
            get { return _postulations; }
            set
            {
                _postulations = value;
                OnPropertyChanged("Postulations");
            }
        }



    }
}
