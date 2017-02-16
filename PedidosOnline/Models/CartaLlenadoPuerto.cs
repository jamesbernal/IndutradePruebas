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
    
    public partial class CartaLlenadoPuerto
    {
        public int RowID { get; set; }
        public int MotonaveID { get; set; }
        public int PuertoID { get; set; }
        public string DescripcionMercancia { get; set; }
        public Nullable<int> Peso { get; set; }
        public int OpcionID { get; set; }
        public Nullable<int> PorcentajeVacio { get; set; }
        public string Importador { get; set; }
        public string Direccion { get; set; }
        public int EmpresaID { get; set; }
        public string NombreSIA { get; set; }
        public int VehiculoID { get; set; }
        public int TerceroID { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
    
        public virtual Vehiculo Vehiculo { get; set; }
        public virtual Tercero Tercero { get; set; }
        public virtual MotoNave MotoNave { get; set; }
        public virtual Opcion Opcion { get; set; }
        public virtual Puerto Puerto { get; set; }
    }
}
