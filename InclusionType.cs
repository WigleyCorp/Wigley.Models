using System.Runtime.Serialization;

namespace Wigley
{
    [DataContract]
    public enum InclusionType
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        Law17934 = 1,
        [EnumMember]
        Law19210 = 6
    }
}