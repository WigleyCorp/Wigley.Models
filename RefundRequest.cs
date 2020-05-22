using System.Runtime.Serialization;

namespace Wigley
{
    [DataContract]
    public class RefundRequest : Reference
    {
        [DataMember]
        public string ClientReferenceId { get; set; }

        [DataMember]
        public decimal Amount { get; set; }

    }
}