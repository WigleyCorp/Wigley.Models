using System.Runtime.Serialization;

namespace Wigley
{
    [DataContract]
    public enum CardStatus
    {
        [EnumMember]
        Ok,
        [EnumMember]
        WarningExpirationInLessThanOneMonth,
        [EnumMember]
        Expired,
        [EnumMember]
        Disabled,
        [EnumMember]
        WaitingForConfirmation
    }
}