//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class orden
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public orden()
        {
            this.orde_detalle = new HashSet<orde_detalle>();
        }
    
        public string id { get; set; }
        public int tipo_oden { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public Nullable<System.TimeSpan> hora { get; set; }
        public Nullable<int> estado { get; set; }
        public Nullable<int> ve_vehiculo_responsable_id { get; set; }
        public Nullable<int> emp_empleado_id { get; set; }
        public string observacion { get; set; }
        public string km_ingreso { get; set; }
        public string km_egreso { get; set; }
    
        public virtual emp_empleado emp_empleado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orde_detalle> orde_detalle { get; set; }
        public virtual ve_vehiculo_responsable ve_vehiculo_responsable { get; set; }
    }
}