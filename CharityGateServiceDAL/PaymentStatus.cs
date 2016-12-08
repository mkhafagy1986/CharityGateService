namespace CharityGateServiceDAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PaymentStatus
    {
        [Key]
        public int PaymentStatusId { get; set; }

        [StringLength(500)]
        public string PaymentStatusText { get; set; }
    }
    public enum PaymentStatusEnum
    {
        Initiated = 1,
        Pending = 2,
        Accepted = 3
    }
}
