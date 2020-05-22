﻿using System.Runtime.Serialization;

namespace Wigley
{
    [DataContract]
    public class CodeRequest
    {
        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public CodeAction Action { get; set; }

        [DataMember]
        public string IssuerReferenceId { get; set; }
    }
}