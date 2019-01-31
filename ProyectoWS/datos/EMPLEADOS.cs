namespace ProyectoWS.datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INACAP.EMPLEADOS")]
    public partial class EMPLEADOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EMPLEADOS()
        {
            //ORDENES = new HashSet<ORDENES>();
        }

        [Key]
        [StringLength(50)]
        public string USUARIO { get; set; }

        [StringLength(50)]
        public string CLAVE { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ORDENES> ORDENES { get; set; }
    }
}
