using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Wigley
{
    [DataContract]
    public class PaymentListLine
    {
        [DataMember]
        public string ClientReferenceId { get; set; }
        [DataMember]
        public int IssuerId { get; set; }
        [DataMember]
        public string AccountNumber { get; set; }
        [DataMember]
        public string CVV { get; set; }
        [DataMember]
        public string ExpirationMMYYYY { get; set; }
        [DataMember]
        public decimal TaxedAmount { get; set; }
        [DataMember]
        public decimal BilledAmount { get; set; }
        [DataMember]
        public string InvoiceNumber { get; set; }
        [DataMember]
        public int CurrencyId { get; set; }
        [DataMember]
        public int Installments { get; set; }
        [DataMember]
        public int? OptionalCommerceId { get; set; }
        [DataMember]
        public string OptionalMetadata { get; set; }
        [DataMember]
        public string OptionalExternalPaymentInfo { get; set; }
        [DataMember]
        public string TransactionID { get; set; }
        [DataMember]
        public string ExecutionDate { get; set; }
        [DataMember]
        public int ResultCode { get; set; }
        [DataMember]
        public string AuthorizationCode { get; set; }

    }
}
