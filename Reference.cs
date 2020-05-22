using System.Runtime.Serialization;

namespace Wigley
{
    [DataContract]
    public class Reference
    {        
        [DataMember]
        public ReferenceType Type { get; set; }
        [DataMember]
        public string MetaReference { get; set; }
    }
}