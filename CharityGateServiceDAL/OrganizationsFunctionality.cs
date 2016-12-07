namespace CharityGateServiceDAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrganizationsFunctionality
    {
        [Key]
        public int OrganizationFunctionalityId { get; set; }

        [StringLength(500)]
        public string OrganizationFunctionalityArabicName { get; set; }

        [StringLength(500)]
        public string OrganizationFunctionalityEnglishName { get; set; }
    }
}
