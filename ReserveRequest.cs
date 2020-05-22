using System.Runtime.Serialization;

namespace Wigley
{
    [DataContract]
    public class ReserveRequest : PaymentRequest
    {
        [DataMember]
        public long ExpirationUTC { get; set; } //Must be included
    }
}