using System.Runtime.Serialization;

namespace Wigley
{
    [DataContract]
    public class AuthorizationInfo
    {
        [DataMember]
        public AuthorizationType Type { get; set; }
        [DataMember]
        public string MetaReference { get; set; }
    }
}