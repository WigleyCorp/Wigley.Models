using System.Runtime.Serialization;

namespace Wigley
{
    [DataContract]
    public class ServerSignedRequest<T> : SignedObject<T>
    {
    }
}