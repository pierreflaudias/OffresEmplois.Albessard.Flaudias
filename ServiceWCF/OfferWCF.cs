using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServiceWCF
{
    [DataContract]
    public class OfferWCF
    {
        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Description { get; set; }

    }
}