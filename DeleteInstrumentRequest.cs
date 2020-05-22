using System.Runtime.Serialization;

namespace Wigley
{
    [DataContract]
    public class DeleteInstrumentRequest : AuthorizationInfo
    {
        [DataMember]
        public string InstrumentToken { get; set; }
    }
}