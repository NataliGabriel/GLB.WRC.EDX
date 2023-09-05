using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using GLB.WRC.EDX.Entidade;

namespace GLB.WRC.EDX.Repos
{
    public class DadosEmbarqueRepositorio
    {
        private ConexaoBanco _conexaoBanco;

        public DadosEmbarqueRepositorio()
        {
            _conexaoBanco = new ConexaoBanco();
        }
        public V_BROKER DadosEmbarque(string referencia)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("SELECT ");
            stringBuilder.Append("S_REFERENCIA, DT_ABERT_PROCESSO, RESP_OPERACIONAL, COD_INCOTERMS, CODIGO_PAIS_PROCEDENCIA, TX_MOEDA_MERC, NR_DI, CODIGO_CIA_TRANSP,");
            stringBuilder.Append("REF_DESPACHANTE, NOME_PROJETO, VB.COD_EXTERNO, NOME_CLIENTE, FAT.COD_EXTERNO AS COD_EXTERNO_FATURADO, FAT.NOME_COMPLETO AS NOME_FATURADO,");
            stringBuilder.Append("CNPJ_ADQUIRENTE, CLI.NOME_COMPLETO, CLI.NOME_RED, CLI.END_COMPLETO, CLI.DSP_NR, CLI.DSP_COMP, CLI.CEP, CLI.CIDADE, CLI.BAIRRO, CLI.ESTADO,");
            stringBuilder.Append("CLI.CNPJ_CPF, CLI.IE, CLI.IM, DATA_REG_DI_SISCOMEX, DATA_PREV_CHEGADA, DATA_PREV_EMBARQUE, DATA_CHEGADA, DT_INSP_MADEIRA, DT_REMOCAO,");
            stringBuilder.Append("DT_EMI_NOTA_FISCAL, DT_ENTREGA_CLIENTE, DT_DESEMBARACO, DT_DOCS_ORIGINAIS, DT_PRESENCA_CARGA, DT_CONF_FISCAL, URF_DESPACHO, URF_ENTRADA_PAIS, ");
            stringBuilder.Append("CODIGO_RECINTO, VL_SEGURO_MOEDA, COD_MOEDA_SEGURO, VL_FRETE_PP_MOEDA, VL_FRETE_CC_MOEDA, COD_MOEDA_FRETE, VL_FRETE_TN_MOEDA, TX_MOEDA_FRETE, ");
            stringBuilder.Append("TX_MOEDA_SEGURO, REF_AG_EXTERNO, UF_DESPACHO, DT_CHEGADA_EADI, DATA_EMB, CANAL, ");
            stringBuilder.Append("NR_IDENT_MASTER, NOME_EMBARCACAO, NR_TERMO, NR_IDENTIFICACAO, NOME_TRANSP, ");
            stringBuilder.Append("ADQ.COD_EXTERNO as COD_EXTERNO_ADQUIRENTE , ADQ.NOME_COMPLETO as NOME_COMPLETO_ADQUIRENTE ,ADQ.END_COMPLETO as END_COMPLETO_ADQUIRENTE , ");
            stringBuilder.Append("ADQ.DSP_NR as DSP_NR_ADQUIRENTE , ADQ.DSP_COMP as DSP_COMP_ADQUIRENTE , ADQ.CEP as CEP_ADQUIRENTE, TIPO_DOC_TRANSPORTE, BANDEIRA_TRANSP, TIPO_TERMO, UTILIZACAO, ");
            stringBuilder.Append("(SELECT TBL_PAIS.COD_PAIS_SISTEMA FROM TBL_PAIS WHERE COD_PAIS = CODIGO_LOCAL_EMBARQUE) AS PAIS_LOCAL_EMBARQUE ");
            stringBuilder.Append("FROM V_BROKER AS VB LEFT JOIN TBL_CADASTRO_GERAL AS FAT ON VB.COD_CLIENTE_BRASIL = FAT.COD_CADASTRO ");
            stringBuilder.Append("LEFT JOIN TBL_CADASTRO_GERAL AS CLI ON VB.COD_CLIENTE_CONSIGNEE = CLI.COD_CADASTRO ");
            stringBuilder.Append("LEFT JOIN TBL_CADASTRO_GERAL AS ADQ ON VB.COD_ADQUIRENTE = ADQ.COD_CADASTRO ");

            stringBuilder.Append($"WHERE N_REFERENCIA = '{referencia}'");
            using (var conexao = _conexaoBanco.sqlConnection())
            {
                return conexao.QueryFirstOrDefault<V_BROKER>(stringBuilder.ToString(), commandTimeout: 10000);
            }
        }
        public List<V_ITENS_ADICAO> ItensAdicao(string referencia)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("SELECT ");
            stringBuilder.Append("CODIGO, REF_CLIENTE, CODIGO_SEQUENCIA, NR_FATURA, NR_PRODUTO, DESC_MERC, QTD_MERC, PESO_TOTAL, AD.MOEDA_MERC, NALADI_SH, NALADI_NCCA, ad.NR_ADICAO, ");
            stringBuilder.Append("IMP.NCM, VALOR_UNITARIO, VALOR_TOTAL_MERC, SIGLA_UNIDADE, AD.COD_SAP_FAB, AD.COD_SAP_EXP, AD.COD_INCOTERMS, AD.NR_LI, ");
            stringBuilder.Append("NUMERO_ATO_DRAWBACK_ADICAO, NR_ITEM_DRAWBACK, QTD_PRODUTO_DRAWBACK, NM_UNI_MED,PAIS_FABRICANTE, PACKING_LIST, PESO_LIQUIDO, PESO_LIQUIDO_UNIT ");
            stringBuilder.Append("FROM V_ITENS_ADICAO IMP INNER JOIN V_ADICAO AD ON IMP.N_REFERENCIA = AD.N_REFERENCIA AND IMP.ADICAO = AD.NR_ADICAO ");
            stringBuilder.Append("WHERE IMP.N_REFERENCIA =@referencia");
            using (var conexao = _conexaoBanco.sqlConnection())
            {
                return (conexao.Query<V_ITENS_ADICAO>(stringBuilder.ToString(), new { referencia }, commandTimeout:10000)).ToList();
            }
        }
        public V_IMPOSTOS_ITENS ImpostosItens(int codigo)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("SELECT ");
            stringBuilder.Append("FRETE, SEGURO, VALOR_II, VALOR_ICMS, ACRESCIMO, BASE_II, VALOR_II_CALCULADO, VALOR_II, ALIQ_NORMAL_II, ");
            stringBuilder.Append("BASE_IPI, IPICalculado, VALOR_IPI, ALIQ_IPI, BASE_ICMS, VALOR_ICMS_CALCULADO, VALOR_ICMS, ALIQ_ICMS,  ");
            stringBuilder.Append("BASE_PIS, PisCalculado, VALOR_PIS, CofinsCalculado, VALOR_COFINS, Aliq_Pis, Aliq_Cofins ");
            stringBuilder.Append("FROM V_IMPOSTOS_ITENS ");
            stringBuilder.Append("WHERE CODIGO = @codigo");
            using (var conexao = _conexaoBanco.sqlConnection())
            {
                return (conexao.QueryFirstOrDefault<V_IMPOSTOS_ITENS>(stringBuilder.ToString(), new { codigo }, commandTimeout:10000));
            }
        }
        public List<V_LANCAMENTOS> Lancamentos(string referencia)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("SELECT ");
            stringBuilder.Append("S_REFERENCIA, VF.NUMERARIO, N_INCLUIR_FATURA, REF_DESPACHANTE, DATA_FATURA, VF.NR_FATURA, VF.OBS, VF.DATA_VENCIMENTO, COD_INTEGRACAO_TITULO, ");
            stringBuilder.Append("VL.VALOR_RS, VL.TIPO_LANCAMENTO  ");
            stringBuilder.Append("V_LANCAMENTOS VL INNER JOIN V_FATURA VF ON VL.NR_FATURA = VF.NR_FATURA ");
            stringBuilder.Append("WHERE VL.N_REFERENCIA = @referencia");
            using (var conexao = _conexaoBanco.sqlConnection())
            {
                return (conexao.Query<V_LANCAMENTOS>(stringBuilder.ToString(), new { referencia })).ToList();
            }
        }
        public List<ACRESCIMOS> Acrescimos(string referencia)
        {
            using (var conexao = _conexaoBanco.sqlConnection())
            {
                return (conexao.Query<ACRESCIMOS>("select NOSSA_REFERENCIA, TIPO_ACRESCIMO, VALOR_ACRESCIMO_MOEDA * TAXA_ACRESCIMO AS VALOR_RS from TBB_ACRESCIMO_VALORACAO_GLOBAL_CAPA where NOSSA_REFERENCIA =@referencia", new { referencia })).ToList();
            }
        }
    }
}
