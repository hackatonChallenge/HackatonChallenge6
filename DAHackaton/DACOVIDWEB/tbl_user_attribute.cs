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
    
    public partial class tbl_user_attribute
    {
        public int id { get; set; }
        public int tbl_user_id { get; set; }
        public string alias { get; set; }
        public string value { get; set; }
        public int state { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public string created_by { get; set; }
    }
}
