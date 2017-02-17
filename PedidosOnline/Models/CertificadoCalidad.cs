
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace PedidosOnline.Models
{

using System;
    using System.Collections.Generic;
    
public partial class CertificadoCalidad
{

    public int RowID { get; set; }

    public int MatrizBLID { get; set; }

    public string Cliente { get; set; }

    public Nullable<int> CiudadID { get; set; }

    public string Direccion { get; set; }

    public Nullable<int> ProductoID { get; set; }

    public string Codigo { get; set; }

    public Nullable<System.DateTime> FechaRevision { get; set; }

    public Nullable<int> Cantidad { get; set; }

    public Nullable<System.DateTime> Fecha_Elaboracion_Producto { get; set; }

    public Nullable<System.DateTime> Fecha_Vencimiento_Producto { get; set; }

    public string UsuarioCreacion { get; set; }

    public Nullable<System.DateTime> FechaCreacion { get; set; }

    public string UsuarioModificacion { get; set; }

    public Nullable<System.DateTime> FechaModificacion { get; set; }



    public virtual Ciudad Ciudad { get; set; }

    public virtual Item Item { get; set; }

    public virtual MatrizBL MatrizBL { get; set; }

}

}
