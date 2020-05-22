﻿using System.Runtime.Serialization;

namespace Wigley
{
    [DataContract]
    public enum TransactionType
    {
        [EnumMember]
        Reserve,
        [EnumMember]
        Purchase,
        [EnumMember]
        Cancel,
        [EnumMember]
        Refund
    }
}