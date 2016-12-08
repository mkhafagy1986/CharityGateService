namespace CharityGateServiceDAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ComplaintsType
    {
        [Key]
        public int ComplaintTypeId { get; set; }

        [StringLength(500)]
        public string ComplaintTypeArabicName { get; set; }

        [StringLength(500)]
        public string ComplaintTypeEnglishName { get; set; }
    }
}
