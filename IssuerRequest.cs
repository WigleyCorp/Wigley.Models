using System.Runtime.Serialization;

namespace Wigley
{
    [DataContract]
    public class IssuerRequest<T> : IssuerRequest
    {
        [DataMember]
        public T Request { get; set; }
    }
    [DataContract]
    public class IssuerRequest
    {
        [DataMember]
        public string Issuer { get; set; }
    }
}