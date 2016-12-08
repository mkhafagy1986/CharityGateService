namespace CharityGateServiceDAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ServiceFunctionality
    {
        public int ServiceFunctionalityId { get; set; }

        [StringLength(500)]
        public string ServiceFunctionalityArabicName { get; set; }

        [StringLength(500)]
        public string ServiceFunctionalityEnglishName { get; set; }

        [StringLength(500)]
        public string ServicePageURL { get; set; }
    }
}
