using GLB.WRC.EDX.ModeloXml;
using System;
using System.Collections.Generic;
using System.Text;
using static GLB.WRC.EDX.Negocio.BLEnum;
namespace GLB.WRC.EDX.Entidade
{
    public class V_BROKER
    {
        public V_BROKER()
        {
            ItensAdicao = new List<V_ITENS_ADICAO>();
            Lancamentos = new List<V_LANCAMENTOS>();
            Acrescimos = new List<ACRESCIMOS>();
        }
        public string S_REFERENCIA { get; set; }
        public DateTime? DT_ABERT_PROCESSO { get; set; }
        public string RESP_OPERACIONAL { get; set; }
        public string COD_INCOTERMS { get; set; }
        public string CODIGO_PAIS_PROCEDENCIA { get; set; }
        public float TX_MOEDA_MERC { get; set; }
        public string NR_DI { get; set; }
        public ViaTranporteEnum? CODIGO_CIA_TRANSP { get; set; }
        public string REF_DESPACHANTE { get; set; }
        public string NOME_PROJETO { get; set; }
        public string COD_EXTERNO { get; set; }
        public string NOME_CLIENTE { get; set; }
        public string COD_EXTERNO_FATURADO { get; set; }
        public string NOME_FATURADO { get; set; }
        public string CNPJ_ADQUIRENTE { get; set; }
        public string NOME_COMPLETO_CLIENTE { get; set; }
        public string NOME_RED_CLIENTE { get; set; }
        public string END_COMPLETO { get; set; }
        public string DSP_NR { get; set; }
        public string DSP_COMP { get; set; }
        public string CEP { get; set; }
        public string CIDADE { get; set; }
        public string BAIRRO { get; set; }
        public string ESTADO { get; set; }
        public string CNPJ_CPF { get; set; }
        public string IE { get; set; }
        public string IM { get; set; }
        public DateTime? DATA_REG_DI_SISCOMEX { get; set; }
        public DateTime? DATA_PREV_CHEGADA { get; set; }
        public DateTime? DATA_PREV_EMBARQUE { get; set; }
        public DateTime? DATA_CHEGADA { get; set; }
        public DateTime? DT_INSP_MADEIRA { get; set; }
        public DateTime? DT_REMOCAO { get; set; }
        public DateTime? DT_EMI_NOTA_FISCAL { get; set; }
        public DateTime? DT_ENTREGA_CLIENTE { get; set; }
        public DateTime? DT_DESEMBARACO { get; set; }
        public DateTime? DT_DOCS_ORIGINAIS { get; set; }
        public DateTime? DT_PRESENCA_CARGA { get; set; }
        public DateTime? DT_CONF_FISCAL { get; set; }
        public DateTime? DT_CHEGADA_EADI { get; set; }
        public DateTime? DATA_EMB { get; set; }
        public string URF_DESPACHO { get; set; }
        public string URF_ENTRADA_PAIS { get; set; }
        public string CODIGO_RECINTO { get; set; }
        public double? VL_SEGURO_MOEDA { get; set; }
        public string COD_MOEDA_SEGURO { get; set; }
        public double? VL_FRETE_PP_MOEDA { get; set; }
        public double? VL_FRETE_CC_MOEDA { get; set; }
        public string COD_MOEDA_FRETE { get; set; }
        public double? VL_FRETE_TN_MOEDA { get; set; }
        public float TX_MOEDA_FRETE { get; set; }
        public float TX_MOEDA_SEGURO { get; set; }
        public string REF_AG_EXTERNO { get; set; }
        public string UF_DESPACHO { get; set; }
        public string NR_IDENT_MASTER { get; set; }
        public string NOME_EMBARCACAO { get; set; }
        public string NR_TERMO { get; set; }
        public string NR_IDENTIFICACAO { get; set; }
        public string NOME_TRANSP { get; set; }
        public string COD_EXTERNO_ADQUIRENTE { get; set; }
        public string NOME_ADQUIRENTE { get; set; }
        public string NOME_COMPLETO_ADQUIRENTE { get; set; }
        public string END_COMPLETO_ADQUIRENTE { get; set; }
        public string DSP_NR_ADQUIRENTE { get; set; }
        public string DSP_COMP_ADQUIRENTE { get; set; }
        public string CEP_ADQUIRENTE { get; set; }
        public string CIDADE_ADQUIRENTE { get; set; }
        public string BAIRRO_ADQUIRENTE { get; set; }
        public string ESTADO_ADQUIRENTE { get; set; }
        public string CNPJ_CPF_ADQUIRENTE { get; set; }
        public string IE_ADQUIRENTE { get; set; }
        public string IM_ADQUIRENTE { get; set; }
        public string CANAL { get; set; }
        public string TIPO_DOC_TRANSPORTE { get; set; }
        public string BANDEIRA_TRANSP { get; set; }
        public string TIPO_TERMO { get; set; }
        public int? UTILIZACAO { get; set; }
        public string PAIS_LOCAL_EMBARQUE { get; set; }
        public string TipoAwbBl
        { 
            get 
            {
                if (TIPO_DOC_TRANSPORTE == "12")
                {
                    return "02";
                }
                return TIPO_DOC_TRANSPORTE;
            } 
        }
        public List<V_ITENS_ADICAO> ItensAdicao { get; set; }
        public List<V_LANCAMENTOS> Lancamentos { get; set; }
        public List<ACRESCIMOS> Acrescimos { get; set; }
    }
}
