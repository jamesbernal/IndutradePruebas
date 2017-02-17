
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
    
public partial class SolicitudLlenado
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public SolicitudLlenado()
    {

        this.VehiculoSolicitudLlenado = new HashSet<VehiculoSolicitudLlenado>();

    }


    public int RowID { get; set; }

    public Nullable<System.DateTime> FechaDescargue { get; set; }

    public int DestinoID { get; set; }

    public int ContratoID { get; set; }

    public string BKK { get; set; }

    public int EmpaqueID { get; set; }

    public Nullable<System.DateTime> FechaCreacion { get; set; }

    public string UsuarioCreacion { get; set; }

    public Nullable<System.DateTime> FechaModificacion { get; set; }

    public string UsuarioModificacion { get; set; }



    public virtual Ciudad Ciudad { get; set; }

    public virtual Contrato Contrato { get; set; }

    public virtual Opcion Opcion { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<VehiculoSolicitudLlenado> VehiculoSolicitudLlenado { get; set; }

}

}
