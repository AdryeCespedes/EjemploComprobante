using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comprobantes
{
    public class Base_ID
    {
        public string Prefijo { get; set; } = String.Empty;
        public int Tipo { get; set; } = 0;
        public long Numero { get; set; } = 0;
        public string Fecha { get; set; } = String.Empty;
        public long Timbrado { get; set; } = 0;
        public string FechaInicioTimbrado { get; set; } = String.Empty;
        public string Serie { get; set; } = String.Empty;
    }

    public class Base_Emisor
    {
        public string NroDocumento { get; set; } = String.Empty;
        public string RazonSocial { get; set; } = String.Empty;
        public string OtraProp1 { get; set; } = String.Empty;
        public string OtraProp2 { get; set; } = String.Empty;
    }
     

}
