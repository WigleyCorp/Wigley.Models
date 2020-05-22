using System.Runtime.Serialization;

namespace Wigley
{
    [DataContract]
    public class CommerceIdRequest
    {
        [DataMember]
        public int CommerceId { get; set; }
    }
}