using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comprobantes
{
    public class ComprobanteID
    {
        public string Prefijo { get; set; } = String.Empty;
        public int Tipo { get; set; } = 0;
        public long Numero { get; set; } = 0;
        public DateOnly  Fecha { get; set; } = DateOnly.MinValue;
        public string Timbrado { get; set; } = String.Empty;
        public DateOnly FechaInicioTimbrado { get; set; } = DateOnly.MinValue;
        public string SerieTimbrado { get; set; } = String.Empty;
    }

    public class ComprobanteEmisor
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

        public List<DatoAdicional>? DatosAdicionales { get; set; } = null;
    }

    public class ComprobanteReceptor
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

        public  List<DatoAdicional>? DatosAdicionales { get; set; } = null; 
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
          PagoDiferido,
          RendicionGastos
    }

    public class ComprobanteCabecera
    {
        public string Concepto { get; set; } =  String.Empty;
        public metodosPago  MetodoPago  { get; set; } =  metodosPago.CuentaCorriente;
        public DateOnly FechaVtoPago { get; set; } = DateOnly.MinValue;
        public uint Moneda { get; set; } = 0;
        public double  Cambio { get; set; } = 1;
        public string Observaciones  { get; set; } =  String.Empty;
    }

    public class DetalleIVA
    {
        public double? IVATasa { get; set; }=null;
        public double IVABaseImponible { get; set; } = 0;
        public double IVAImporte { get; set; } = 0;
    }

    public enum OtrosTributosTipo
    { 
        IVA, 
        Ganancias, 
        IngresosBrutos,
        SUSS,
        ImpuestosInternos
    }

    public class DetalleOtrosTributos
    {
        public OtrosTributosTipo? OtrosTributostipo { get; set; } =  null;
        public double OtrosTributosbaseimponible { get; set; } = 0;
        public double OtrosTributosimporte { get; set; } = 0;
    }
    public class ComprobanteTotales
    {
        public double ImporteTotal { get; set; } = 0;
        public double ImporteGravado { get; set; } = 0;
        public double ImporteNoGravado { get; set; } = 0;
        public double ImporteExento { get; set; } = 0;
        public double ImporteIVANoInsc { get; set; } = 0;
        public double ImporteRedondeo { get; set; } = 0;
        public List<DetalleIVA>? DetallesIVA { get; set; } = null; 
        public List<DetalleOtrosTributos>? DetallesOtrosTributos { get; set; } = null; 
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
        public double MedioPagoImporte { get; set; } = 0;
        public double MedioPagoCantidad { get; set; } = 0;
        public uint MedioPagoMoneda { get; set; } = 0;
        public double MedioPagoCotizacion { get; set; } = 0;
        public Cheque Cheque { get; set; } = new Cheque ();
        public Tarjeta Tarjeta { get; set; } = new Tarjeta ();
    }

    public class ComprobanteMediosPago
    {
        public List<MedioPago>? MediosPago { get; set; } = null; 
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
        public List<ComprobanteAsociado>? ComprobantesAsociado { get; set; } = null; 
    }

    public class ComprobantePeriodoAsociado
    {
        public DateOnly FechaDesde { get; set; } = DateOnly.MinValue;
        public DateOnly FechaHasta { get; set; } = DateOnly.MinValue;
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
        public List<Permiso>? Permisos { get; set; } = null; 
    }

    public enum CondicionIVA
    {
        Exento,
        NoGravado,
        Gravado
    }
    public class Item
    { 
        public string Unidad { get; set; } = String.Empty;
        public string UnidadDesc { get; set; } = String.Empty;

        public string CodigoMadre { get; set; } = String.Empty;
        public string Codigo { get; set; } = String.Empty;
        public string CodigoAlternativo { get; set; } = String.Empty;
        public string Color { get; set; } = String.Empty;
        public string Medida { get; set; } = String.Empty;
        public string Descripcion { get; set; } = String.Empty;
        public string DescripcionLarga { get; set; } = String.Empty;

        public double? IVATasa { get; set; } = null;
        public CondicionIVA? CondicionIVA { get; set; } = null;
        public double Cantidad { get; set; } = 0;
        public double PrecioUnitario { get; set; } = 0;
        public double ImporteBonificacion { get; set; } = 0;
        public double ImporteDescuento { get; set; } = 0;
        public double ImporteRecargo { get; set; } = 0;
        public double ImporteIVA { get; set; } = 0;
        public double ImporteGravado { get; set; } = 0;
        public bool EsRedondeo { get; set; } = false;
        public List<DatoAdicional>? DatosAdicionales { get; set; } = null;
        public List<DetalleOtrosTributos>? DetallesOtrosTributos { get; set; } = null;
    }
    public class ComprobanteItems
    {
        public List<Item>? Items { get; set; } = null;
    }

    public class ItemRem
    {
        public string Unidad1 { get; set; } = String.Empty;
        public string Unidad2 { get; set; } = String.Empty;
        public string CodigoMadre { get; set; } = String.Empty;
        public string Codigo { get; set; } = String.Empty;
        public string Color { get; set; } = String.Empty;
        public string Medida { get; set; } = String.Empty;
        public double Cantidad1 { get; set; } = 0;
        public double Cantidad2 { get; set; } = 0;
        public string Partida { get; set; } = String.Empty;
    }

    public class ComprobanteItemsRem{
       public List<ItemRem>? Items { get; set; } = null;
    }

    public class ComprobanteVenta
    {
        public ComprobanteID Identificador { get; set; } = new ComprobanteID ();
        public ComprobanteEmisor Emisor { get; set; } = new ComprobanteEmisor();
        public ComprobanteReceptor Receptor { get; set; } = new ComprobanteReceptor();
        public ComprobanteCabecera Cabecera { get; set; } = new ComprobanteCabecera();
        public ComprobanteTotales Totales { get; set; } = new ComprobanteTotales();
        public ComprobanteMediosPago? MediosPago { get; set; } = null;
        public ComprobanteAsociados? Asociados { get; set; } = null;
        public ComprobantePeriodoAsociado? PeriodoAsociado { get; set; } = null;    
        public ComprobanteItems? Items { get; set; } = null;
    }

    public class ComprobanteExportacion
    {
        public ComprobanteID Identificador { get; set; } = new ComprobanteID();
        public ComprobanteEmisor Emisor { get; set; } = new ComprobanteEmisor();
        public ComprobanteReceptor Receptor { get; set; } = new ComprobanteReceptor();
        public ComprobanteCabecera Cabecera { get; set; } = new ComprobanteCabecera();
        public ComprobanteCabeceraExportacion CabeceraExportacion { get; set; } = new ComprobanteCabeceraExportacion();
        public ComprobanteTotales Totales { get; set; } = new ComprobanteTotales();
        public ComprobanteAsociados? Asociados { get; set; } = null;
        public ComprobantePeriodoAsociado? PeriodoAsociado { get; set; } = null;
        public ComprobanteItems Items { get; set; } = new ComprobanteItems();
    }
}
