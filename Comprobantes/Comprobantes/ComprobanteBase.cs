using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comprobantes
{
    public class BaseComprobanteID
    {
        public string Prefijo { get; set; } = String.Empty;
        public int Tipo { get; set; } = 0;
        public long Numero { get; set; } = 0;
        public DateOnly  Fecha { get; set; } = DateOnly.MinValue;
        public string Timbrado { get; set; } = String.Empty;
        public DateOnly  FechaInicioTimbrado { get; set; } = DateOnly.MinValue;
        public string SerieTimbrado { get; set; } = String.Empty;
    }

    public class BaseEmisor
    {
        public string NroDocumento { get; set; } = String.Empty;
        public string RazonSocial { get; set; } = String.Empty;
        public string Domicilio { get; set; } = String.Empty;
        public string Domicilio2 { get; set; } = String.Empty;
        public string Localidad { get; set; } = String.Empty;
        public string ProvinciaCodigo { get; set; } = String.Empty;
        public string ProvinciaDescripcion { get; set; } = String.Empty;
        public string Telefono { get; set; } = String.Empty;
        public string SucursalCodigo { get; set; } = String.Empty;
        public string SucursalDescripcion { get; set; } = String.Empty;
    }

    public class BaseReceptor
    {
        public string TipoDocumento { get; set; } = String.Empty;
        public string NroDocumento { get; set; } = String.Empty;
        public string RazonSocial { get; set; } = String.Empty;
        public string Domicilio { get; set; } = String.Empty;
        public string Domicilio2 { get; set; } = String.Empty;
        public string Localidad { get; set; } = String.Empty;
        public string ProvinciaCodigo { get; set; } = String.Empty;
        public string ProvinciaDescripcion { get; set; } = String.Empty;
        public string Telefono { get; set; } = String.Empty;
        public string Pais { get; set; } = String.Empty;
        public string GLN { get; set; } = String.Empty;
        public string NroOrden { get; set; } = String.Empty;

        public  List<DatoAdicional> DatosAdicionales { get; set; } = new List<DatoAdicional>(); 
    }

    public class DatoAdicional
    {
        public string DatoCodigo { get; set; } =  String.Empty;
        public string DatoDescripcion { get; set; } = String.Empty;
        public string DatoValorCodigo { get; set; } = String.Empty;
        public string DatoValorDescripcion { get; set; } = String.Empty;
    }

     

}
