using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Wigley
{
    [DataContract]
    public class PaymentRequestList 
    {
        [DataMember]
        public int OrderID { get; set; }
        [DataMember]
        public List<PaymentListLine> ListLines { get; set; }
    }
}