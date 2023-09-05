using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace GLB.WRC.EDX.Entidade
{
    public class V_IMPOSTOS_ITENS
    {
        public int CODIGO { get; set; }
        public double? FRETE { get; set; }
        public double? SEGURO { get; set; }
        public double? VALOR_II { get; set; }
        public double? VALOR_ICMS { get; set; }
        public double? ACRESCIMO { get; set; }
        public double? BASE_II { get; set; }
        public double? VALOR_II_CALCULADO { get; set; }
        public double? ALIQ_NORMAL_II { get; set; }
        public double? BASE_IPI { get; set; }
        public double? IPICalculado { get; set; }
        public double? VALOR_IPI { get; set; }
        public double? ALIQ_IPI { get; set; }
        public double? BASE_ICMS { get; set; }
        public double? VALOR_ICMS_CALCULADO { get; set; }
        public double? ALIQ_ICMS { get; set; }
        public double? BASE_PIS { get; set; }
        public double? PisCalculado { get; set; }
        public double? VALOR_PIS { get; set; }
        public double? CofinsCalculado { get; set; }
        public double? VALOR_COFINS { get; set; }
        public double? Aliq_Pis { get; set; }
        public double? Aliq_Cofins { get; set; }


    }
}
