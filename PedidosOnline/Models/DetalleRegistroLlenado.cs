
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
    
public partial class DetalleRegistroLlenado
{

    public int RowID { get; set; }

    public Nullable<int> EncabezadoRegistroLlenadoID { get; set; }

    public Nullable<int> VehiculoID { get; set; }

    public Nullable<System.DateTime> FechaCreacion { get; set; }

    public Nullable<System.DateTime> FechaInspeccion { get; set; }

    public string NumeroCTU_IT { get; set; }

    public string NumeroFlexitanks { get; set; }

    public Nullable<bool> InspeccionAntinarcoticos { get; set; }

    public string Sello { get; set; }

    public string TipoSello { get; set; }

    public Nullable<System.DateTime> FechaLlegada { get; set; }

    public Nullable<int> RemolqueID { get; set; }

    public string ProveedorFlexitanks { get; set; }



    public virtual Vehiculo Vehiculo { get; set; }

    public virtual EncabezadoRegistroLlenado EncabezadoRegistroLlenado { get; set; }

    public virtual Vehiculo Vehiculo1 { get; set; }

}

}
