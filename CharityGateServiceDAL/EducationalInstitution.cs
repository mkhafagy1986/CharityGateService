namespace CharityGateServiceDAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EducationalInstitution
    {
        public int EducationalInstitutionId { get; set; }

        [StringLength(500)]
        public string EducationalInstitutionName { get; set; }
    }
}
