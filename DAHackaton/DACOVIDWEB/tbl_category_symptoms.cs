//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DACOVIDWEB
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_category_symptoms
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_category_symptoms()
        {
            this.tbl_symptoms = new HashSet<tbl_symptoms>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public int state { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public string created_by { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_symptoms> tbl_symptoms { get; set; }
    }
}
