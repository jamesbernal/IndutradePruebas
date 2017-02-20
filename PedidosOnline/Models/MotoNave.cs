
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
    
public partial class MotoNave
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public MotoNave()
    {

        this.CartaLlenadoPuerto = new HashSet<CartaLlenadoPuerto>();

        this.CertificadoMadera = new HashSet<CertificadoMadera>();

    }


    public int RowID { get; set; }

    public Nullable<int> Tipo { get; set; }

    public string Codigo { get; set; }

    public string Nombre { get; set; }

    public Nullable<decimal> Altura { get; set; }

    public Nullable<decimal> Largo { get; set; }

    public Nullable<decimal> Ancho { get; set; }

    public Nullable<decimal> TRB { get; set; }

    public string Descripcion { get; set; }

    public Nullable<bool> Activo { get; set; }

    public string UsuarioCreacion { get; set; }

    public Nullable<System.DateTime> FechaCreacion { get; set; }

    public string UsuarioModificacion { get; set; }

    public Nullable<System.DateTime> FechaModificacion { get; set; }

    public Nullable<int> NumeroViaje { get; set; }



    public virtual Opcion Opcion { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<CartaLlenadoPuerto> CartaLlenadoPuerto { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<CertificadoMadera> CertificadoMadera { get; set; }

}

}
