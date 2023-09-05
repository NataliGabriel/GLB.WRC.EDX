using GLB.WRC.EDX.Entidade;
using GLB.WRC.EDX.ModeloXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GLB.WRC.EDX.Negocio.TraduzirXML
{
    public class BLTraduzirXML
    {
        private V_BROKER _dadosBroker;

        public BLTraduzirXML(V_BROKER dadosBroker)
        {
            _dadosBroker = dadosBroker;
        }
        public  ATUALIZA_EMBARQUE XMLAtualizaEmbarque()
        {
            ATUALIZA_EMBARQUE xml = new ATUALIZA_EMBARQUE();
            xml.MAIN = new BLMain(_dadosBroker).Traduir();
            xml.BUK = new BLBuk(_dadosBroker).Traduzir();
            xml.PAR = new BLPar(_dadosBroker).Traduzir();
            xml.PARS = new BLPars (_dadosBroker).Traduzir();
            xml.DAT = new BLDat(_dadosBroker).Traduzir();
            xml.DI = new BLDi(_dadosBroker).Traduzir();
            xml.BL = new BLBL(_dadosBroker).Traduzir();
            xml.SHP = new BLShp(_dadosBroker.ItensAdicao).Traduzir();
            return xml;
        }
    }
}
