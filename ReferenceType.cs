using System.Runtime.Serialization;

namespace Wigley
{
    [DataContract]
    public enum ReferenceType
    {
        [EnumMember]
        WigleyTransactionId,
        [EnumMember]
        ClientPurchaseReferenceId,
        [EnumMember]
        ClientCancelReferenceId,
        [EnumMember]
        ClientReserveReferenceId,
        [EnumMember]
        ClientRefundReferenceId,
    }
}