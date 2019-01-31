namespace ProyectoWS.datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INACAP.PIZZAS")]
    public partial class PIZZAS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal IDPIZZA { get; set; }

        [StringLength(50)]
        public string TITULO { get; set; }

        public decimal? PRECIO { get; set; }

        [StringLength(50)]
        public string IMAGEN { get; set; }

        public virtual ORDENES ORDENES { get; set; }
    }
}
