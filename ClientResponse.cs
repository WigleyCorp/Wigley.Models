using System.Runtime.Serialization;

namespace Wigley
{
    [DataContract]
    public class ClientResponse : ServerResponse
    {
        [DataMember]
        public string Client { get; set; }
    }
}