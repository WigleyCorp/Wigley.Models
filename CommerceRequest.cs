using System.Runtime.Serialization;

namespace Wigley
{
    [DataContract]
    public class CommerceRequest
    {
        [DataMember]
        public string Name { get; set; }
    }
}