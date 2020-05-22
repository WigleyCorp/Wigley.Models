using System.Runtime.Serialization;

namespace Wigley
{
    [DataContract]
    public class TimeLimit
    {
        [DataMember]
        public int SecondsLeft;
        [DataMember]
        public FieldType RequirementAfterTimeLimit { get; set; }
    }
}