namespace CharityGateServiceDAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ComplaintsTransaction
    {
        [Key]
        public int TransactionId { get; set; }

        [StringLength(500)]
        public string UserSessionId { get; set; }

        [StringLength(500)]
        public string UserMSISDN { get; set; }

        [StringLength(500)]
        public string UserTOKEN { get; set; }

        public int? ComplaintTypeId { get; set; }

        [StringLength(500)]
        public string ComplainantContactNumber { get; set; }

        public DateTime? TransactionDate { get; set; }
    }
}
