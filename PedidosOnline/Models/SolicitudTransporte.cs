//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PedidosOnline.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SolicitudTransporte
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SolicitudTransporte()
        {
            this.TipoVehiculo = new HashSet<TipoVehiculo>();
        }
    
        public int RowID { get; set; }
        public int ContratoID { get; set; }
        public int ProveedorID { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public string Flete { get; set; }
        public Nullable<int> OpcionID { get; set; }
        public Nullable<int> PlantaCargueID { get; set; }
        public Nullable<System.DateTime> FechaCargue { get; set; }
        public string RequisitosCargue { get; set; }
        public Nullable<int> PlantaDescargueID { get; set; }
        public Nullable<System.DateTime> FechaEntrega { get; set; }
        public string RequisitosDescargue { get; set; }
        public string UsuarioCreacion { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
    
        public virtual Contrato Contrato { get; set; }
        public virtual Opcion Opcion { get; set; }
        public virtual Planta Planta { get; set; }
        public virtual Planta Planta1 { get; set; }
        public virtual Tercero Tercero { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipoVehiculo> TipoVehiculo { get; set; }
    }
}