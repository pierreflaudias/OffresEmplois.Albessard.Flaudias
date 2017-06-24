using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServiceWCF
{
    
    [ServiceContract]
    public interface IOfferService
    {
        [OperationContract]
        [WebInvoke(Method ="GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            UriTemplate = "offers")]
        List<OfferWCF> GetAllOffers();
    }
}
