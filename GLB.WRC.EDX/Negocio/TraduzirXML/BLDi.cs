using GLB.WRC.EDX.Entidade;
using GLB.WRC.EDX.ModeloXml;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLB.WRC.EDX.Negocio.TraduzirXML
{
    public class BLDi
    {
        private V_BROKER _dadosBroker;
        public BLDi(V_BROKER dadosBroker)
        {
            _dadosBroker = dadosBroker;
        }
        public DI Traduzir ()
        {
            DI di = new DI
            {
                DINUM = _dadosBroker.NR_DI,
                IMPTYP = "",
                MODDESP = "",
                URFDESP = _dadosBroker.URF_DESPACHO,
                URFENTR = _dadosBroker.URF_ENTRADA_PAIS,
                RECALF = _dadosBroker.CODIGO_RECINTO,
                INSUR = Util.FormatoValor(_dadosBroker.VL_SEGURO_MOEDA, 6),
                INSWR = _dadosBroker.COD_MOEDA_SEGURO,
                PREPD = Util.FormatoValor(_dadosBroker.VL_FRETE_PP_MOEDA, 6),
                COLLEC = Util.FormatoValor(_dadosBroker.VL_FRETE_CC_MOEDA, 6),
                PREPWR = _dadosBroker.COD_MOEDA_FRETE,
                LFREIG = Util.FormatoValor(_dadosBroker.VL_FRETE_TN_MOEDA, 6),
                LFREWR = "790",
                KURDI =  Util.FormatoValor(_dadosBroker.TX_MOEDA_MERC, 8),
                FRERT = Util.FormatoValor(_dadosBroker.TX_MOEDA_FRETE, 8),
                INSRT = Util.FormatoValor(_dadosBroker.TX_MOEDA_SEGURO, 8),
                CANAL =  (_dadosBroker.CANAL == "D" ? "1" : "0") ,
                REFADM = _dadosBroker.REF_AG_EXTERNO,
                UFDESEMB = _dadosBroker.URF_DESPACHO,
                TPINTERMD = ( _dadosBroker.NOME_ADQUIRENTE == null ? "1" : "2"),
                PERM = "",
                DENUM = "",
                XPNS = TraduzirXPNS()

            };
            return di;
        }
        private List<XPNSXml> TraduzirXPNS ()
        {
            List<XPNSXml> listaXPNS = new List<XPNSXml>();
            foreach (var acrescimo in _dadosBroker.Acrescimos)
            {
                listaXPNS.Add(new XPNSXml
                {
                    KSCHL = acrescimo.TIPO_ACRESCIMO,
                    NETWR = Util.FormatoValor(acrescimo.VALOR_RS, 2)
                });
            }
            return listaXPNS;
        }
    }
}
