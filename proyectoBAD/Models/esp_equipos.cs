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
    
    public partial class esp_equipos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public esp_equipos()
        {
            this.equipos_fisicos = new HashSet<equipos_fisicos>();
            this.linea_compra = new HashSet<linea_compra>();
        }
    
        public int id { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public decimal potencia { get; set; }
        public decimal consumo_corriente { get; set; }
        public Nullable<decimal> capacidad_btu { get; set; }
        public int equipo { get; set; }
        public int empresa { get; set; }
        public decimal precio { get; set; }
    
        public virtual equipos equipos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<equipos_fisicos> equipos_fisicos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<linea_compra> linea_compra { get; set; }
        public virtual empresas empresas { get; set; }
    }
}
