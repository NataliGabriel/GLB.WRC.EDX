using GLB.WRC.EDX.Entidade;
using GLB.WRC.EDX.ModeloXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLB.WRC.EDX.Negocio.TraduzirXML
{
    public class BLPar
    {
        private V_BROKER _dadosBroker;
        public BLPar(V_BROKER dadosBroker)
        {
            _dadosBroker = dadosBroker;
        }
        public PAR Traduzir ()
        {
            PAR par = new PAR
            {
                PARID = _dadosBroker.COD_EXTERNO,
                NAME1 = _dadosBroker.NOME_COMPLETO_CLIENTE,
                NAME2 = _dadosBroker.NOME_CLIENTE,
                STREET = _dadosBroker.END_COMPLETO,
                HOUSE_NUM1 = _dadosBroker.DSP_NR,
                HOUSE_NUM2 = _dadosBroker.DSP_COMP,
                POST_CODE1 = _dadosBroker.CEP,
                CITY1 = _dadosBroker.CIDADE,
                CITY2 = _dadosBroker.BAIRRO,
                PSTLZ = _dadosBroker.CEP,
                REGION = _dadosBroker.ESTADO,
                COUNTRY = "105",
                STCD1 = _dadosBroker.CNPJ_CPF,
                STCD3 = _dadosBroker.IE,
                STCD4 = _dadosBroker.IM,
                PARVW = _dadosBroker.COD_EXTERNO,
                VTXTK = ""
            };
            return par;
        }
    }
}
