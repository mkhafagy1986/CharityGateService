namespace CharityGateServiceDAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PaymentTransaction
    {
        public int PaymentTransactionId { get; set; }

        public int? TransactionId { get; set; }

        public int? PaymentTypeId { get; set; }

        public decimal? PaymentAmount { get; set; }

        public DateTime? PaymentDate { get; set; }

        public int? PaymentStatus { get; set; }
    }
    public enum PaymentStatusEnum
    {
        Initiated = 1,
        Pending = 2,
        Accepted = 3
    }
}
