namespace CharityGateServiceDAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CharityInstitution
    {
        public int CharityInstitutionId { get; set; }

        [StringLength(500)]
        public string CharityInstitutionName { get; set; }
    }
}
