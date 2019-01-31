namespace ProyectoWS.datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INACAP.REGIONS")]
    public partial class REGIONS
    {
        [Key]
        public decimal REGION_ID { get; set; }

        [StringLength(25)]
        public string REGION_NAME { get; set; }
    }
}
