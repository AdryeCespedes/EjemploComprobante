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

    public enum metodosPago
    { 
          CuentaCorriente,
          Contado,
          PagoDiferido
          RendicionGastos
    }

    public class ComprobanteCabecera
    {
        public string Concepto { get; set; } =  String.Empty;
        public metodosPago  MetodoPago  { get; set; } =  metodosPago.CuentaCorriente;
        public DateOnly FechaVtoPago { get; set; } = DateOnly.MinValue;
        public uint Moneda { get; set; } = 0;
        public float  Cambio { get; set; } = 1;
        public string Observaciones  { get; set; } =  String.Empty;
    }

    public class DetalleIVA
    {
        public float IVAtasa { get; set; } =  0;
        public float IVAbaseImponible { get; set; } = 0;
        public float IVAimporte { get; set; } = 0;
    }

    public enum OtrosTributosTipo
    { 
        IVA, 
        Ganancias, 
        Ingresos Brutos,
        SUSS,
        Impuestos Internos
    }

    public class DetalleOtrosTributos
    {
        public OtrosTributosTipo OtrosTributostipo { get; set; } =  OtrosTributosTipo.IVA ;
        public float OtrosTributosbaseimponible { get; set; } = 0;
        public float OtrosTributosimporte { get; set; } = 0;
    }
    public class ComprobanteTotales
    {
        public float ImporteTotal { get; set; } = 0;
        public float ImporteGravado { get; set; } = 0;
        public float ImporteNoGravado { get; set; } = 0;
        public float ImporteExento { get; set; } = 0;
        public float ImporteIVANoInsc { get; set; } = 0;
        public float ImporteRedondeo { get; set; } = 0;
        public float ImporteRedondeo { get; set; } = 0;
        public List<DetalleIVA> DetallesIVA { get; set; } = new List<DetalleIVA>(); 
        public List<DetalleOtrosTributos> DetallesOtrosTributos { get; set; } = new List<DetalleOtrosTributos>(); 
    }

    public enum tipoMedioPago
    {
        Efectivo,
        Cheque,
        Tarjeta,
        PagoPorBanco,
        Pagare
    }

    public class Cheque
    {
        public string ChequeNumero { get; set; } = String.Empty;
        public string ChequeBancoEmisor { get; set; } = String.Empty;
    }

    public enum tipoTarjeta
    {
        debito,
        credito
    }
    public class Tarjeta
    {
        public string TarjetaCodigo { get; set; } = String.Empty;
        public tipoTarjeta TarjetaTipo { get; set; } = tipoTarjeta.debito;
    }

    public class MedioPago
    {
        public tipoMedioPago TipoMedioPago  { get; set; } = tipoMedioPago.Efectivo ;
        public string MedioPagoCodigo { get; set; } = String.Empty;
        public string MedioPagoDescripcion { get; set; } = String.Empty;
        public float MedioPagoImporte { get; set; } = 0;
        public float MedioPagoCantidad { get; set; } = 0;
        public uint MedioPagoMoneda { get; set; } = 0;
        public float MedioPagoCotizacion { get; set; } = 0;
        public Cheque Cheque { get; set; } = new Cheque ();
        public Tarjeta Tarjeta { get; set; } = new Tarjeta ();
    }

    public class ComprobanteMediosPago
    {
        public List<MedioPago> MediosPago { get; set; } = new List<MedioPago>(); 
    }

    public enum soporte
    {
        Impreso,
        Electronico
    }
    public class ComprobanteAsociado
    {
        public string Prefijo { get; set; } = String.Empty;
        public int Tipo { get; set; } = 0;
        public long Numero { get; set; } = 0;
        public DateOnly  Fecha { get; set; } = DateOnly.MinValue;
        public string NroDocumento { get; set; } = String.Empty;
        public string CodigoAutorizacion { get; set; } = String.Empty;
        public soporte Soporte { get; set; } = soporte.Electronico;
    }
    
    public class ComprobanteAsociados
    {
        public List<ComprobanteAsociado> ComprobantesAsociado { get; set; } = new List<ComprobanteAsociado>(); 
    }

    public class ComprobantePeriodoAsociado
    {
        public DateOnly  FechaDesde { get; set; } = DateOnly.MinValue;
        public DateOnly  FechaHasta { get; set; } = DateOnly.MinValue;
    }
   
    public class Permiso
    {
        public string ID { get; set; } = String.Empty;
        public string Pais { get; set; } = String.Empty;
    }

    public class ComprobanteCabeceraExportacion
    {
        public string Incoterm { get; set; } = String.Empty;
        public string ViaTransporte { get; set; } = String.Empty;
        public string PaisDestino { get; set; } = String.Empty;
        public uint Idioma { get; set; } = 1; 
        public List<Permiso> Permisos { get; set; } = new List<Permiso>(); 
    }

    /*public class Comprobante
    {
        public BaseComprobanteID ComprobanteID { get; set; } = new BaseComprobanteID ();
        public ComprobanteCabeceraExportacion? ComprobanteCabeceraExportacion { get; set; };

    }*/
}
