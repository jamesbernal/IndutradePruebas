
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
    
public partial class ListaPrecio
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public ListaPrecio()
    {

        this.Precio = new HashSet<Precio>();

        this.Sucursal = new HashSet<Sucursal>();

        this.Sucursal1 = new HashSet<Sucursal>();

        this.Sucursal2 = new HashSet<Sucursal>();

        this.Sucursal3 = new HashSet<Sucursal>();

    }


    public int RowID { get; set; }

    public string RowIDERP { get; set; }

    public string Descripcion { get; set; }

    public System.DateTime FechaCreacion { get; set; }

    public string UsuarioCreacion { get; set; }

    public Nullable<System.DateTime> FechaModificacion { get; set; }

    public string UsuarioModificacion { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Precio> Precio { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Sucursal> Sucursal { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Sucursal> Sucursal1 { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Sucursal> Sucursal2 { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Sucursal> Sucursal3 { get; set; }

}

}
