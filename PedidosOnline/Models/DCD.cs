
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
    
public partial class DCD
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public DCD()
    {

        this.FEP = new HashSet<FEP>();

    }


    public int RowID { get; set; }

    public int ContratoID { get; set; }

    public string RepresentanteLegal { get; set; }

    public string NroConvenio { get; set; }

    public string Mes { get; set; }

    public string Año { get; set; }

    public string FechaExpedicion { get; set; }

    public string Destino { get; set; }



    public virtual Contrato Contrato { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<FEP> FEP { get; set; }

}

}
