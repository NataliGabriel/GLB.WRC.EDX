using System;
using System.Collections.Generic;
using System.Text;

namespace GLB.WRC.EDX.Entidade
{
    public class V_ITENS_ADICAO
    {
        public V_ITENS_ADICAO()
        {
            Impostos = new V_IMPOSTOS_ITENS();
        }
        public int CODIGO { get; set; }
        public string REF_CLIENTE { get; set; }
        public string CODIGO_SEQUENCIA { get; set; }
        public string NR_FATURA { get; set; }
        public string NR_PRODUTO { get; set; }
        public string DESC_MERC { get; set; }
        public float QTD_MERC { get; set; }
        public float PESO_TOTAL { get; set; }
        public string MOEDA_MERC { get; set; }
        public string NALADI_SH { get; set; }
        public string NALADI_NCCA { get; set; }
        public string NR_ADICAO { get; set; }
        public string NCM { get; set; }
        public double? VALOR_UNITARIO { get; set; }
        public double? VALOR_TOTAL_MERC { get; set; }
        public string SIGLA_UNIDADE { get; set; }
        public string COD_SAP_FAB { get; set; }
        public string COD_SAP_EXP { get; set; }
        public string COD_INCOTERMS { get; set; }
        public string NR_LI { get; set; }
        public string NUMERO_ATO_DRAWBACK_ADICAO { get; set; }
        public string NR_ITEM_DRAWBACK { get; set; }
        public string QTD_PRODUTO_DRAWBACK { get; set; }
        public string NM_UNI_MED { get; set; }
        public string PAIS_FABRICANTE { get; set; }
        public string PACKING_LIST { get; set; }
        public float PESO_LIQUIDO { get; set; }
        public float PESO_LIQUIDO_UNIT { get; set; }
        public V_IMPOSTOS_ITENS Impostos { get; set; }
    }
}
