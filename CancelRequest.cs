using System.Runtime.Serialization;

namespace Wigley
{
    [DataContract]
    public class CancelRequest : Reference
    {
        [DataMember]
        public string ClientReferenceId { get; set; }

        [DataMember]
        public int? OptionalClientId { get; set; }
    }
}