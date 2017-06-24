using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Model.Entities;
using BusinessLayer;

namespace ServiceWCF
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "OfferService" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez OfferService.svc ou OfferService.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class OfferService : IOfferService
    {
        public List<OfferWCF> GetAllOffers()
        {
            List<Offer> offersFromDB =  Manager.Instance.GetAllOffers();
            List<OfferWCF> offersToReturn = new List<OfferWCF>();
            foreach(Offer o in offersFromDB)
            {
                offersToReturn.Add(new OfferWCF
                {
                    Description = o.Description,
                    Title = o.Title,
                    Id = o.Id
                });
            }
            return offersToReturn;
        }
    }
}
