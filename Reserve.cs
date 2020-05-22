using System.Runtime.Serialization;

namespace Wigley
{
    [DataContract]
    public class Reserve : Reference
    {
        [DataMember]
        public bool Commit { get; set; }
    }
}