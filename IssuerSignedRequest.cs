using System.Runtime.Serialization;

namespace Wigley
{
    [DataContract]
    public class IssuerSignedRequest<T> : SignedObject<IssuerRequest<T>> { }

    [DataContract]
    public class IssuerSignedRequest : SignedObject<IssuerRequest> { }
}