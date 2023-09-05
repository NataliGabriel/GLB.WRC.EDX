using GLB.WRC.EDX.ModeloXml;
using GLB.WRC.EDX.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using GLB.WRC.EDX.Negocio;
using Microsoft.Extensions.Logging;
using GLB.WRC.EDX.Negocio.TraduzirXML;

namespace GLB.WRC.EDX.TESTE
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("-------- Primeiro Request --------");
                string referencia = "DSSAO0011-0323";
                var blGerarXml = new BLGerarXML();

                blGerarXml.GerarAtualizaEmbarque(referencia);

                Console.WriteLine("-------- Fim Request --------");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);

            }
        }
    }

}
