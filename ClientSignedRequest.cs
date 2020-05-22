using System.Runtime.Serialization;

namespace Wigley
{
    [DataContract]
    public class ClientSignedRequest<T> : SignedObject<ClientRequest<T>> { }

    [DataContract]
    public class ClientSignedRequest : SignedObject<ClientRequest> { }


}