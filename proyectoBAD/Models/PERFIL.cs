//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace proyectoBAD.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PERFIL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PERFIL()
        {
            this.PERFILUSUARIOs = new HashSet<PERFILUSUARIO>();
            this.PERFILPERMISOes = new HashSet<PERFILPERMISO>();
        }
    
        public int IDPERFIL { get; set; }
        public string PERFIL1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERFILUSUARIO> PERFILUSUARIOs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERFILPERMISO> PERFILPERMISOes { get; set; }
    }
}