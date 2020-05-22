using System.Runtime.Serialization;

namespace Wigley
{
    [DataContract]
    public class PublicKeyInfo
    {
        [DataMember]
        public string Fingerprint { get; set; }
        [DataMember]
        public string Key { get; set; }
    }
}
