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
    
    public partial class emp_empleado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public emp_empleado()
        {
            this.orden = new HashSet<orden>();
        }
    
        public int id { get; set; }
        public string cedula { get; set; }
        public Nullable<int> cargo_id { get; set; }
        public string pwd { get; set; }
        public Nullable<bool> activo { get; set; }
        public Nullable<System.DateTime> fecha_activacion { get; set; }
        public Nullable<System.DateTime> fecha_desactivacion { get; set; }
        public string per_persona_cedula_activacion { get; set; }
        public Nullable<int> tipo_usuario { get; set; }
        public string observaciones_activacion { get; set; }
        public string observaciones_desactivacion { get; set; }
    
        public virtual per_persona per_persona { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orden> orden { get; set; }
    }
}