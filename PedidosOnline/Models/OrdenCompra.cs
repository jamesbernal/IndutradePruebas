
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
    
public partial class OrdenCompra
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public OrdenCompra()
    {

        this.OrdenCompraItem = new HashSet<OrdenCompraItem>();

    }


    public int RowID { get; set; }

    public Nullable<System.DateTime> Fecha { get; set; }

    public Nullable<int> ProveedorID { get; set; }

    public Nullable<int> ContratoID { get; set; }

    public Nullable<int> SucursalFactura { get; set; }

    public Nullable<int> FormaPagoID { get; set; }

    public Nullable<int> SucursalDespacho { get; set; }

    public string Observaciones { get; set; }

    public string UsuarioCreacion { get; set; }

    public Nullable<System.DateTime> FechaCreacion { get; set; }

    public string UsuarioModificacion { get; set; }

    public Nullable<System.DateTime> FechaModificacion { get; set; }



    public virtual Sucursal Sucursal { get; set; }

    public virtual Sucursal Sucursal1 { get; set; }

    public virtual Tercero Tercero { get; set; }

    public virtual Opcion Opcion { get; set; }

    public virtual Contrato Contrato { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<OrdenCompraItem> OrdenCompraItem { get; set; }

}

}
