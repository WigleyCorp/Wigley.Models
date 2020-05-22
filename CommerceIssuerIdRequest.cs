using System.Runtime.Serialization;

namespace Wigley
{
    [DataContract]
    public class CommerceIssuerIdRequest
    {
        [DataMember]
        public int CommerceId { get; set; }
        [DataMember]
        public int IssuerId { get; set; }
    }
}