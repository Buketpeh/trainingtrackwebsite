//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication4.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MetotRol
    {
        public int No { get; set; }
        public Nullable<int> MetotNo { get; set; }
        public Nullable<int> RolNo { get; set; }
    
        public virtual Metot Metot { get; set; }
        public virtual Rol Rol { get; set; }
    }
}