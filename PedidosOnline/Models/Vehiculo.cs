
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
    
public partial class Vehiculo
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Vehiculo()
    {

        this.AutorizacionCargueVehiculo = new HashSet<AutorizacionCargueVehiculo>();

        this.AutorizacionCargueVehiculo1 = new HashSet<AutorizacionCargueVehiculo>();

        this.DetalleRegistroLlenado = new HashSet<DetalleRegistroLlenado>();

        this.DetalleRegistroLlenado1 = new HashSet<DetalleRegistroLlenado>();

    }


    public int RowID { get; set; }

    public Nullable<int> TipoVehiculoID { get; set; }

    public string Placa { get; set; }

    public string Año { get; set; }

    public string Modelo { get; set; }

    public string Color { get; set; }

    public Nullable<int> CapacidadKG { get; set; }

    public Nullable<int> Volumen { get; set; }

    public string Descripcion { get; set; }

    public Nullable<System.DateTime> FechaCreacion { get; set; }

    public Nullable<bool> Estado { get; set; }

    public Nullable<int> MarcaID { get; set; }

    public Nullable<int> Rendimiento { get; set; }

    public Nullable<double> PesoVacio { get; set; }

    public Nullable<double> CargaMaxima { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<AutorizacionCargueVehiculo> AutorizacionCargueVehiculo { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<AutorizacionCargueVehiculo> AutorizacionCargueVehiculo1 { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<DetalleRegistroLlenado> DetalleRegistroLlenado { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<DetalleRegistroLlenado> DetalleRegistroLlenado1 { get; set; }

    public virtual Opcion Opcion { get; set; }

    public virtual Opcion Opcion1 { get; set; }

}

}
