using GLB.WRC.EDX.Entidade;
using GLB.WRC.EDX.ModeloXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLB.WRC.EDX.Negocio.TraduzirXML
{
    public class BLBL
    {
        private V_BROKER _dadosBroker;
        public BLBL(V_BROKER dadosBroker)
        {
            _dadosBroker = dadosBroker;
        }
        public BL Traduzir()
        {
            BL bl = new BL
            {
                BLNUM = _dadosBroker.NR_IDENT_MASTER,
                LOADTP = _dadosBroker.TipoAwbBl,
                SHPNAM = _dadosBroker.NOME_EMBARCACAO,
                LNDVLS = _dadosBroker.BANDEIRA_TRANSP,
                MANTYP = _dadosBroker.TIPO_TERMO,
                MANNUM = _dadosBroker.NR_TERMO,
                HSNUM = _dadosBroker.NR_IDENTIFICACAO,
                HSDAT = Util.FormatoData(_dadosBroker.DATA_EMB),
                CARGUT = _dadosBroker.UTILIZACAO.ToString(),
                ZLANDO = _dadosBroker.CODIGO_PAIS_PROCEDENCIA,
                LDNAQUI = _dadosBroker.PAIS_LOCAL_EMBARQUE,
                CARGAG = "",
                FCLLCL = "",
                VSLOWN = _dadosBroker.NOME_TRANSP,
                DTANUM = _dadosBroker.NR_TERMO,
            };
            return bl;
        }
    }
}
