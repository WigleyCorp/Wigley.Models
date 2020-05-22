using System.Runtime.Serialization;

namespace Wigley
{
    [DataContract]
    public class IntrumentCallback : InstrumentWithMetadata, IClientCallback
    {
        [DataMember]
        public string SessionId { get; set; }

        [DataMember]
        public string Client { get; set; }

        [DataMember]
        public ActionType Action { get; set; }

    }
}
