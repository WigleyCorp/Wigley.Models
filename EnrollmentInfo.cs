using System.Runtime.Serialization;

namespace Wigley
{
    [DataContract]
    public class EnrollmentInfo
    {        
        [DataMember]
        public bool EnrollmentStatus { get; set; }
    }
}
