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
    
    public partial class tbl_user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_user()
        {
            this.tbl_donation = new HashSet<tbl_donation>();
            this.tbl_donation1 = new HashSet<tbl_donation>();
            this.tbl_user_attribute = new HashSet<tbl_user_attribute>();
        }
    
        public int id { get; set; }
        public string DNI { get; set; }
        public int tbl_role_id { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public Nullable<System.DateTime> fecha_nacimiento { get; set; }
        public string surname { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public int state { get; set; }
        public System.DateTime created_at { get; set; }
        public string created_by { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_donation> tbl_donation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_donation> tbl_donation1 { get; set; }
        public virtual tbl_role tbl_role { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_user_attribute> tbl_user_attribute { get; set; }
    }
}
