using System.Runtime.Serialization;

namespace Wigley
{
    [DataContract]
    public class ClientSignedResponse : SignedObject<ClientResponse>
    {
    }
}