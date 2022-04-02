using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Wigley
{
    [DataContract]
    public class ExpressCheckoutSettingsDto
    {
        [DataMember]
        public DisplayOptionsDto Display { get; set; }
        [DataMember]
        public BuiltInPagesOptionsDto BuiltInPages { get; set; }
    }
}
