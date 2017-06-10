using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OffersManagement.ViewModels
{
    public class MainVM : BaseViewModel
    {
        private ListOffersVM _listeOffers = null;

        public MainVM()
        {
            _listeOffers = new ListOffersVM();
        }

        public ListOffersVM ListOffers
        {
            get { return _listeOffers; }
            set { _listeOffers = value; }
        }
    }
}
