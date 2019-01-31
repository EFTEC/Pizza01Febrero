namespace ProyectoWS.datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INACAP.ORDENES")]
    public partial class ORDENES
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal IDORDEN { get; set; }

        public decimal? IDPIZZA { get; set; }

        public DateTime? FECHA { get; set; }

        public decimal? CANTIDAD { get; set; }

        [StringLength(50)]
        public string USUARIO { get; set; }

        public virtual EMPLEADOS EMPLEADOS { get; set; }

        public virtual PIZZAS PIZZAS { get; set; }
    }
}
