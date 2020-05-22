using System.Runtime.Serialization;

namespace Wigley
{
        [DataContract]
        public class Check
        {
            [DataMember]
            public string Id { get; set; }

            [DataMember]
            public string Uri { get; set; }

            [DataMember]
            public string EnrollmentStatus { get; set; }
        }
}


    