//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KonsoolEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kontakt
    {
        public int KontaktId { get; set; }
        public int InimeneId { get; set; }
        public int KontaktiTyypId { get; set; }
        public string Vaartus { get; set; }
    
        public virtual Inimene Inimene { get; set; }
        public virtual KontaktiTyyp KontaktiTyyp { get; set; }
    }
}