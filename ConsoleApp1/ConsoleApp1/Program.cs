
using AutoMapper;
using Newtonsoft.Json;

namespace Comprobantes
{
    public class Program
    {

        static void Main()
        {

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("                 GENERICO                    ");
            Console.WriteLine("---------------------------------------------");
            ComprobanteVenta Comp = new ComprobanteVenta();
            Comp.Identificador.Prefijo = "023-045";
            Comp.Identificador.Fecha = DateOnly.FromDateTime (DateTime.Now);
            Comp.Identificador.SerieTimbrado = "A-7866";
            Comp.Identificador.FechaInicioTimbrado = DateOnly.FromDateTime(DateTime.Now);
            Comp.Identificador.Timbrado = "987000";
            Comp.Identificador.Tipo = 1;
            Comp.Identificador.Numero = 3455000;
            Comp.Emisor.NroDocumento = "778-20039534";
            Comp.Emisor.RazonSocial = "Cucha Cucha Construcciones SA";


            Console.WriteLine(JsonConvert.SerializeObject(Comp, Formatting.Indented));
            Console.WriteLine("---------------------------------------------");
            
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("                 PARAGUAY                    ");
            Console.WriteLine("---------------------------------------------");

            string strJson = Fiscalizar(JsonConvert.SerializeObject(Comp));

            Console.WriteLine(strJson);
            Console.WriteLine("---------------------------------------------");
            
            Console.ReadLine();

        }

        static string Fiscalizar(string jsonString)
        {
            ComprobanteFACNCND? Comp =  JsonConvert.DeserializeObject <ComprobanteFACNCND>(jsonString); 
            ComprobantePyFACNCND? Comp2;
            var config = new MapperConfiguration(cfg => cfg.CreateMap <ComprobanteFACNCND, ComprobantePyFACNCND>());
            var mapper = new Mapper(config);
            Comp2 = mapper.Map <ComprobantePyFACNCND> (Comp);
            Comp2.PropNew1 = "pepe";   
            return JsonConvert.SerializeObject(Comp2, Formatting.Indented);
        }

        public class ComprobantePyFACNCND
        {
            public ComprobanteEmisor? Emisor { get; set;}
            public ComprobanteID? ID { get; set; }
            public string? PropNew1 { get; set; }

        }
    }    
}

