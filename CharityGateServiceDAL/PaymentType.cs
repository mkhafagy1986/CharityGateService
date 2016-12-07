namespace CharityGateServiceDAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PaymentType
    {
        public int PaymentTypeId { get; set; }

        [StringLength(500)]
        public string PaymentTypeArabicName { get; set; }

        [StringLength(500)]
        public string PaymentTypeEnglishName { get; set; }
    }
}
