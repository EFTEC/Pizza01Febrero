namespace ProyectoWS.datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INACAP.CLIENTES")]
    public partial class CLIENTES
    {
        [Key]
        [StringLength(12)]
        public string RUT { get; set; }

        [StringLength(50)]
        public string NOMBRE { get; set; }

        public decimal? TELEFONO { get; set; }

        [StringLength(2000)]
        public string DIRECCION { get; set; }
    }
}
