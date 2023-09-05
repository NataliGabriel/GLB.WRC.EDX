using GLB.WRC.EDX.Entidade;
using GLB.WRC.EDX.ModeloXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLB.WRC.EDX.Negocio.TraduzirXML
{
    public class BLMain
    {
        private V_BROKER _dadosBroker;

        public BLMain(V_BROKER dadosBroker)
        {
            _dadosBroker = dadosBroker;
        }
        public MAIN Traduir()
        {
            MAIN main = new MAIN
            {
                SBELN = _dadosBroker.S_REFERENCIA,
                SHIPT = "STD",
                CREDAT = Util.FormatoData(_dadosBroker.DT_ABERT_PROCESSO),
                CRENAM = _dadosBroker.RESP_OPERACIONAL,
                ZTERM = "",
                INCO1 = _dadosBroker.COD_INCOTERMS,
                ZOLLAO = "",
                ZLANDO = _dadosBroker.CODIGO_PAIS_PROCEDENCIA,
                ZOLLAD = "",
                ZLANDD = "",
                KURSP = Util.FormatoValor(_dadosBroker.TX_MOEDA_MERC, 6),
                STATU = "",
                DITYP = _dadosBroker.NR_DI,
                BFMAR = _dadosBroker.CODIGO_CIA_TRANSP.ToString(),
                BROKNM = _dadosBroker.REF_DESPACHANTE,
                PROJN = _dadosBroker.NOME_PROJETO,
                RETDAT = "",
                LIMDATE = "",
                SHPCLASS = "",
                CNPJADQ = ""
            };
            return main;
        }
    }
}
