
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
    
public partial class DetalleMatrizBL
{

    public int RowID { get; set; }

    public Nullable<int> EncabezadoMatrizBLID { get; set; }

    public string NoEmpaque { get; set; }

    public string NetWeight { get; set; }

    public string NoFlexitanks { get; set; }

    public string GrossWeight { get; set; }

    public string NoSecuritySeal { get; set; }



    public virtual EncabezadoMatrizBL EncabezadoMatrizBL { get; set; }

}

}
