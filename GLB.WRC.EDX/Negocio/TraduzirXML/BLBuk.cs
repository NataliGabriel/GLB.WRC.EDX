using GLB.WRC.EDX.Entidade;
using GLB.WRC.EDX.ModeloXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLB.WRC.EDX.Negocio.TraduzirXML
{
    public class BLBuk
    {
        private V_BROKER _dadosBroker;

        public BLBuk(V_BROKER dadosBroker)
        {
            _dadosBroker = dadosBroker;
        }
        public BUK Traduzir()
        {
            BUK buk = new BUK
            {
                BUKRS = _dadosBroker.COD_EXTERNO,
                EKORG = _dadosBroker.NOME_CLIENTE,
                BRANCH = _dadosBroker.COD_EXTERNO_FATURADO,
                PARTYP = _dadosBroker.NOME_FATURADO,
                CSGNE = _dadosBroker.CNPJ_ADQUIRENTE,
            };
            return buk;
        }
    }
}
