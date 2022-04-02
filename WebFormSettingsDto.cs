﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Wigley
{
    [DataContract]
    public class WebFormSettingsDto
    {
        [DataMember]
        public UIOptionsDto UI { get; set; } // Opciones de UI
        [DataMember]
        public ExpressCheckoutSettingsDto ExpressCheckout { get; set; } // Opciones especificas de ExpressCheckout
        [DataMember]
        public TokenizationSettingsDto Tokenization { get; set; } // Opciones especificas de Tokenization
    }
}
