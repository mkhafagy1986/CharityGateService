namespace CharityGateServiceDAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrganizationsItem
    {
        [Key]
        public int OrganizationItemId { get; set; }

        [StringLength(500)]
        public string OrganizationItemArabicName { get; set; }

        [StringLength(500)]
        public string OrganizationItemEnglishName { get; set; }

        public int? OrganizationTypeId { get; set; }
    }
}
