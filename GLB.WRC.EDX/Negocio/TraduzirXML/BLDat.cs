using GLB.WRC.EDX.Entidade;
using GLB.WRC.EDX.ModeloXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLB.WRC.EDX.Negocio.TraduzirXML
{
    public class BLDat
    {
        private V_BROKER _dadosBroker;
        public BLDat(V_BROKER dadosBroker)
        {
            _dadosBroker = dadosBroker;
        }
        public DAT Traduzir ()
        {
            DAT dat = new DAT
            {
                DIRDAT = Util.FormatoData(_dadosBroker.DATA_REG_DI_SISCOMEX),
                ETADAT = Util.FormatoData(_dadosBroker.DATA_PREV_CHEGADA),
                ETPDAT = Util.FormatoData(_dadosBroker.DATA_PREV_CHEGADA),
                ETDDAT = Util.FormatoData(_dadosBroker.DATA_PREV_EMBARQUE),
                ATRDAT = Util.FormatoData(_dadosBroker.DATA_CHEGADA),
                FUMDAT = Util.FormatoData(_dadosBroker.DT_INSP_MADEIRA),
                REMDAT = Util.FormatoData(_dadosBroker.DT_REMOCAO),
                LOADAT = Util.FormatoData(_dadosBroker.DT_CHEGADA_EADI),
                NFGDAT = Util.FormatoData(_dadosBroker.DT_EMI_NOTA_FISCAL),
                NFCDAT = "",
                PLNDAT = "",
                EINDT = "",
                DELDAT = Util.FormatoData(_dadosBroker.DT_ENTREGA_CLIENTE),
                CLRDAT = Util.FormatoData(_dadosBroker.DT_DESEMBARACO),
                OVRDDT = Util.FormatoData(_dadosBroker.DATA_PREV_EMBARQUE),
                OVRADT = Util.FormatoData(_dadosBroker.DATA_PREV_CHEGADA),
                RECDOCORG = Util.FormatoData(_dadosBroker.DT_DOCS_ORIGINAIS),
                ECERTORG = "",
                PRESCARGADAT = Util.FormatoData(_dadosBroker.DT_PRESENCA_CARGA),
                INSDAT = Util.FormatoData(_dadosBroker.DT_CONF_FISCAL),
                RECDAT = Util.FormatoData(_dadosBroker.DT_DOCS_ORIGINAIS),
                BLDAT = Util.FormatoData(_dadosBroker.DATA_EMB),
                ETDPDT = Util.FormatoData(_dadosBroker.DATA_PREV_EMBARQUE),
                ALCDAT = "",
                LOADDATE = "",
                DTCOLT = "",
                DTEMBFIM = Util.FormatoData(_dadosBroker.DATA_EMB),
            };
            return dat;
        }
    }
}
