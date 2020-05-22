using System.Runtime.Serialization;

namespace Wigley
{
    [DataContract]
    public enum AuthorizationType
    {
        [EnumMember]
        ClientReference,
        [EnumMember]
        OAuth,
        [EnumMember]
        Anonymous
    }
}
