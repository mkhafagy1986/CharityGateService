namespace CharityGateServiceDAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrganizationsType
    {
        [Key]
        public int OrganizationId { get; set; }

        [StringLength(500)]
        public string OrganizationArabicName { get; set; }

        [StringLength(500)]
        public string OrganizationEnglishName { get; set; }
    }
}
