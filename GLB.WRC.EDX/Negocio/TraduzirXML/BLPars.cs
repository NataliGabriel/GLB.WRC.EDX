using GLB.WRC.EDX.Entidade;
using GLB.WRC.EDX.ModeloXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLB.WRC.EDX.Negocio.TraduzirXML
{
    public class BLPars
    {
        private V_BROKER _dadosBroker;
        public BLPars(V_BROKER dadosBroker)
        {
            _dadosBroker = dadosBroker;
        }
        public PARS Traduzir()
        {
            PARS pars = new PARS
            {
                PARID = _dadosBroker.COD_EXTERNO_ADQUIRENTE,
                NAME1 = _dadosBroker.NOME_COMPLETO_ADQUIRENTE,
                NAME2 = _dadosBroker.NOME_ADQUIRENTE,
                STREET = _dadosBroker.END_COMPLETO_ADQUIRENTE,
                HOUSE_NUM1 = _dadosBroker.DSP_NR_ADQUIRENTE,
                HOUSE_NUM2 = _dadosBroker.DSP_COMP_ADQUIRENTE,
                POST_CODE1 = _dadosBroker.CEP_ADQUIRENTE,
                CITY1 = _dadosBroker.CIDADE_ADQUIRENTE,
                CITY2 = _dadosBroker.BAIRRO_ADQUIRENTE,
                PSTLZ = _dadosBroker.CEP_ADQUIRENTE,
                REGION = _dadosBroker.ESTADO_ADQUIRENTE,
                COUNTRY = "105",
                STCD1 = _dadosBroker.CNPJ_CPF_ADQUIRENTE,
                STCD3 = _dadosBroker.IE_ADQUIRENTE,
                STCD4 = _dadosBroker.IM_ADQUIRENTE,
                PARVW = _dadosBroker.COD_EXTERNO_ADQUIRENTE,
                VTXTK = ""
            };
            return pars;
        }
    }
}
