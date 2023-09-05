using GLB.WRC.EDX.Negocio.Requisicao;
using GLB.WRC.EDX.Negocio.TraduzirXML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLB.WRC.EDX.Negocio
{
    public class BLGerarXML
    {

        public BLGerarXML()
        {
        }
        public void GerarAtualizaEmbarque (string referencia)
        {
            try
            {
                var _blBroker = new BLBroker();
                var dadosBroker = _blBroker.DadosBroker(referencia);
                BLTraduzirXML blTraduzir = new BLTraduzirXML(dadosBroker);
                var xmlEmbarque = blTraduzir.XMLAtualizaEmbarque();
                EnviarRequest.GerarEEnviarXML(xmlEmbarque, "ATUALIZA_EMBARQUE");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
