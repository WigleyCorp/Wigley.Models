using System.Runtime.Serialization;

namespace Wigley
{
    [DataContract]
    public class TransactionCallback : Transaction, IClientCallback
    {
        [DataMember]
        public string Client { get; set; }
    }
}