using GLB.WRC.EDX.Entidade;
using GLB.WRC.EDX.ModeloXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLB.WRC.EDX.Negocio.TraduzirXML
{

    public class BLPck
    {
        private List<V_LANCAMENTOS> _lancamentos;
        public BLPck(List<V_LANCAMENTOS> lancamentos)
        {
            _lancamentos = lancamentos;
        }
        public PCK Traduzir()
        {
            PCK pck = new PCK
            {
                SBELN = _lancamentos[0].S_REFERENCIA,
                DOCNR = "",
                PCTYP = _lancamentos[0].ADouPC,
                PARID = _lancamentos[0].REF_DESPACHANTE,
                BLDAT = Util.FormatoData(_lancamentos[0].DATA_FATURA),
                XBLNR = _lancamentos[0].NR_FATURA,
                ZUONR = "",
                BKTXT = _lancamentos[0].OBS,
                SGTXT = _lancamentos[0].OBS,
                ZFBDT = Util.FormatoData(_lancamentos[0].DATA_VENCIMENTO),
                ABLFD = Util.FormatoData(_lancamentos[0].DATA_VENCIMENTO),
                STATU = "1",
                TXPNS = TraduzirTXPNS()
            };
            return pck;
        }
        private List<TXPNSXml> TraduzirTXPNS()
        {
            List<TXPNSXml> tXPNSXmls = new List<TXPNSXml>();
            foreach (var item in _lancamentos)
            {
                tXPNSXmls.Add(new TXPNSXml
                {
                    KSCHL = item.COD_INTEGRACAO_TITULO,
                    NETWR = Util.FormatoValor(item.VALOR_RS, 2),
                    UNREALIZED = item.Quitado
                });
            }
            return tXPNSXmls;
        }
    }
}
