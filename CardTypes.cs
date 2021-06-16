using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Wigley
{
    [DataContract]
    public enum CardTypes
    {
        [EnumMember]
        MexicanDebit=1,
        [EnumMember]
        MexicanCredit = 2,
        [EnumMember]
        MexicanPrepaid = 5,
        [EnumMember]
        Debit=3,
        [EnumMember]
        Credit=4,
        [EnumMember]
        Prepaid=6,
        [EnumMember]
        Unknown=0,
        [EnumMember]
        Bank = 8
    }
}
