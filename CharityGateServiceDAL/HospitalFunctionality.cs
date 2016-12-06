namespace CharityGateServiceDAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HospitalFunctionality
    {
        public int HospitalFunctionalityId { get; set; }

        [StringLength(500)]
        public string HospitalFunctionalityName { get; set; }
    }
}
