
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
    
public partial class AutorizacionCargueVehiculo
{

    public int RowID { get; set; }

    public Nullable<int> AutorizacionCargueID { get; set; }

    public Nullable<int> TerceroID { get; set; }

    public Nullable<int> RemolqueID { get; set; }

    public string UsuarioCreacion { get; set; }

    public Nullable<System.DateTime> FechaCreacion { get; set; }

    public string UsuarioModificacion { get; set; }

    public Nullable<System.DateTime> FechaModificacion { get; set; }

    public Nullable<int> VehiculoID { get; set; }



    public virtual Tercero Tercero { get; set; }

    public virtual AutorizacionCargue AutorizacionCargue { get; set; }

    public virtual Vehiculo Vehiculo { get; set; }

    public virtual Vehiculo Vehiculo1 { get; set; }

}

}
