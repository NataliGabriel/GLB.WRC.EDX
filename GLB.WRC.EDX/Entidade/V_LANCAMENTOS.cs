using System;
using System.Collections.Generic;
using System.Text;

namespace GLB.WRC.EDX.Entidade
{
    public class V_LANCAMENTOS
    {
        public string S_REFERENCIA { get; set; }
        public bool NUMERARIO { get; set; }
        public string N_INCLUIR_FATURA { get; set; }
        public string REF_DESPACHANTE { get; set; }
        public DateTime? DATA_FATURA { get; set; }
        public string NR_FATURA { get; set; }
        public string OBS { get; set; }
        public DateTime? DATA_VENCIMENTO { get; set; }
        public string COD_INTEGRACAO_TITULO { get; set; }
        public double VALOR_RS { get; set; }
        public int? TIPO_LANCAMENTO { get; set; }
        public string ADouPC
        {
            get
            {
                if (NUMERARIO == true) return "AD";
                return "PC";
            }
        }
        public string Quitado
        {
            get
            {
                if (TIPO_LANCAMENTO == 3) return "X";
                return "";
            }
        }
    }
}
