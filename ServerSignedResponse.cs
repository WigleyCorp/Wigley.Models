using System.Runtime.Serialization;

namespace Wigley
{
    [DataContract]
    public class ServerSignedResponse<T> : SignedObject<ServerResponse<T>> { }

    [DataContract]
    public class ServerSignedResponse : SignedObject<ServerResponse> { }
}