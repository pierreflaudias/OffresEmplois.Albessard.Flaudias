using BusinessLayer;
using Model.Entities;
using OffersManagement.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace OffersManagement.ViewModels
{
    public class DetailOfferVM : BaseViewModel
    {
        #region ------Variables------

        private int _id;
        private string _title;
        private float _salary;
        private string _responsible;
        private DateTime _date;
        private string _description;
        private Status _status;
        private int _statusId;
        private ObservableCollection<Status> _listStatuses;
        private ObservableCollection<Postulation> _postulations;
        private CommandHandler _actionModifyOffer;

        #endregion


        #region ------Constructor------

        public DetailOfferVM(Offer o)
        {
            _id = o.Id;
            _title = o.Title;
            _salary = o.Salary;
            _responsible = o.Responsible;
            _date = o.Date;
            _description = o.Description;
            _status = o.Status;
            _statusId = o.StatusId;
            _postulations = new ObservableCollection<Postulation>();
            if (o.Postulations != null)
            {
                _postulations = new ObservableCollection<Postulation>(o.Postulations);
            }
            _listStatuses = new ObservableCollection<Status>();
            List<Status> listTmp = Manager.Instance.GetAllStatuses();
            foreach(Status stat in listTmp)
            {
                _listStatuses.Add(stat);
            }
        }

        #endregion


        #region ------Properties------

        public int Id
        {
            get { return _id; }
            set { _id = value; }
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

        public Status Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public int StatusId
        {
            get { return _statusId; }
            set { _statusId = value; }
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

        public ObservableCollection<Status> ListStatuses
        {
            get { return _listStatuses; }
            set
            {
                _listStatuses = value;
                OnPropertyChanged("ListStatuses");
            }
        }

        #endregion


        #region ------Commands------

        public ICommand ActionModifyOffer
        {
            get
            {
                if (_actionModifyOffer == null)
                    _actionModifyOffer = new CommandHandler(() => this.ModifyOffer());
                return _actionModifyOffer;
            }
        }

       
        #endregion


        #region ------Methods------

        public void ModifyOffer()
        {
            Manager.Instance.UpdateOffer(new Offer
            {
                Date = Date,
                Description = Description,
                Id = Id,
                Postulations = Postulations,
                Responsible = Responsible,
                Salary = Salary,
                StatusId = StatusId,
                Title = Title
            });
        }

        #endregion

    }
}
