using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Wigley
{
    [DataContract]
    public class BuiltInPagesOptionsDto
    {
        [DataMember]
        public bool? CheckoutSuccessPage { get; set; }
        [DataMember]
        public bool? CheckoutErrorPage { get; set; }
    }
}
