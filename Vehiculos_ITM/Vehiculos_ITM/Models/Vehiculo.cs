//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vehiculos_ITM.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class Vehiculo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vehiculo()
        {
            this.Ventas = new HashSet<Venta>();
        }
    
        public int Id { get; set; }
        public string Motor { get; set; }
        public int Num_Puertas { get; set; }
        public string Tipo_Combustible { get; set; }
        public int Marca { get; set; }
        public string Accesorios { get; set; }
        public string Nombre { get; set; }
        [JsonIgnore]
        public virtual Marca Marca1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        public virtual ICollection<Venta> Ventas { get; set; }
    }
}
