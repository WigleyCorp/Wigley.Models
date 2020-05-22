using System.Runtime.Serialization;

namespace Wigley
{
    [DataContract]
    public class InstrumentWithMetadata
    {
        [DataMember]
        public PaymentInstrument PaymentInstrument { get; set; }
        [DataMember]
        public string OptionalMetadata { get; set; }
    }
}