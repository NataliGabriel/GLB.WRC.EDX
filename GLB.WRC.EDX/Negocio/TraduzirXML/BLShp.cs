using GLB.WRC.EDX.Entidade;
using GLB.WRC.EDX.ModeloXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLB.WRC.EDX.Negocio.TraduzirXML
{
    public class BLShp
    {
        private List<V_ITENS_ADICAO> _itensAdicao;

        public BLShp(List<V_ITENS_ADICAO> itensAdicao)
        {
            _itensAdicao = itensAdicao;
        }
        public List<SHP> Traduzir()
        {
            List<SHP> listaSHP = new List<SHP>();
            foreach (var item in _itensAdicao)
            {
                listaSHP.Add(new
                SHP
                {
                    SBELN = item.REF_CLIENTE,
                    SBELP = item.CODIGO_SEQUENCIA,
                    XBELN = item.PACKING_LIST,
                    XBELP = "",
                    NBELP = "",
                    XBLNR = "",
                    KNTTP = "",
                    EPSTP = "",
                    MATNR = item.NR_PRODUTO,
                    MAKTX_TEXT = TraduzirMAKTX_TEXT(item.DESC_MERC),
                    MENGEE = Util.FormatoValor(item.QTD_MERC, 3),
                    NETPR = Util.FormatoValor(item.PESO_LIQUIDO_UNIT, 2),
                    NETWR = Util.FormatoValor(item.PESO_LIQUIDO, 2),
                    WAERS = item.MOEDA_MERC,
                    PEINH = "",
                    MEINS = "",
                    NLADH = item.NALADI_SH,
                    NALDA = item.NALADI_NCCA,
                    ALADI = "",
                    ADICAO = item.NR_ADICAO,
                    SEQAD = item.CODIGO_SEQUENCIA,
                    BPRME = "",
                    J_1BNBM = item.NCM,
                    CHARG = "",
                    NVE = "",
                    LGORT = "",
                    WERKS = "",
                    EKGRP = "",
                    NTGEW = Util.FormatoValor(item.PESO_LIQUIDO_UNIT, 3),
                    BRGEW = Util.FormatoValor(item.PESO_TOTAL / item.QTD_MERC, 3),
                    NTGCV = Util.FormatoValor(item.PESO_LIQUIDO, 3),
                    BRGCV = Util.FormatoValor(item.PESO_TOTAL, 2),
                    GEWEI = "",
                    VOLUM = Util.FormatoValor(item.VALOR_UNITARIO, 3),
                    VOLCV = Util.FormatoValor(item.VALOR_TOTAL_MERC, 3),
                    VOLEH = item.SIGLA_UNIDADE,
                    MFRNR = item.COD_SAP_FAB,
                    LIFNR = item.COD_SAP_EXP,
                    ZTERM = "",
                    INCO1 = item.COD_INCOTERMS,
                    LI = item.NR_LI,
                    LINUM = "",
                    LIDAT = "",
                    LIDEF = "",
                    NDRBCK = item.NUMERO_ATO_DRAWBACK_ADICAO,
                    DBITM = item.NR_ITEM_DRAWBACK,
                    MENGS = item.QTD_PRODUTO_DRAWBACK,
                    MEIST = item.NM_UNI_MED,
                    NETWR_DRW = Util.FormatoValor(item.VALOR_TOTAL_MERC, 2),
                    MWSKZ = "",
                    FREE = "",
                    CONTNUM = "",
                    ORIG = "",
                    MDTYP = "",
                    FIELD1 = "",
                    FIELD2 = "",
                    FIELD3 = "",
                    FIELD4 = "",
                    CB1 = "",
                    CB2 = "",
                    CB3 = "",
                    CB4 = "",
                    NFSK = TraduzirNFSK(item),
                    TTAX = TraduzirTTAX(item)
                });
            }
            return listaSHP;
        }
        private MAKTX_TEXTXml TraduzirMAKTX_TEXT(string texto)
        {
            MAKTX_TEXTXml mAKTX = new MAKTX_TEXTXml
            {
                TEXT = texto
            };
            return mAKTX;
        }
        private NFSKXml TraduzirNFSK(V_ITENS_ADICAO item)
        {
            NFSKXml nFSKXml = new NFSKXml
            {
                FOBBRL_VL = Util.FormatoValor(item.VALOR_TOTAL_MERC, 2),
                NETFRE_VL = Util.FormatoValor(item.Impostos.FRETE, 4),
                NETINS_VL = Util.FormatoValor(item.Impostos.SEGURO, 4),
                NETOTH_II_VL = Util.FormatoValor(item.Impostos.VALOR_II, 4),
                NETOTH_ICMS_VL = Util.FormatoValor(item.Impostos.VALOR_ICMS, 4),
                NETOTH_VL = Util.FormatoValor(item.Impostos.ACRESCIMO, 4),
                CIF_VL = Util.FormatoValor(item.Impostos.BASE_II, 4)
            };
            return nFSKXml;
        }
        private TTAXXml TraduzirTTAX(V_ITENS_ADICAO item)
        {
            var impII = new BaseImpostos
            {
                BASE = Util.FormatoValor(item.Impostos.BASE_II, 2),
                TAXVAL = Util.FormatoValor(item.Impostos.VALOR_II_CALCULADO, 2),
                TAXPAY = Util.FormatoValor(item.Impostos.VALOR_II, 2),
                RATE = Util.FormatoValor(item.Impostos.ALIQ_NORMAL_II, 2)
            };
            var impIPI = new BaseImpostos
            {
                BASE = Util.FormatoValor(item.Impostos.BASE_IPI, 2),
                TAXVAL = Util.FormatoValor(item.Impostos.IPICalculado, 2),
                TAXPAY = Util.FormatoValor(item.Impostos.VALOR_IPI, 2),
                RATE = Util.FormatoValor(item.Impostos.ALIQ_IPI, 2)
            };
            var impPIS = new BaseImpostos
            {
                BASE = Util.FormatoValor(item.Impostos.BASE_PIS, 2),
                TAXVAL = Util.FormatoValor(item.Impostos.PisCalculado, 2),
                TAXPAY = Util.FormatoValor(item.Impostos.VALOR_PIS, 2),
                RATE = Util.FormatoValor(item.Impostos.Aliq_Pis, 2)
            };
            var impCOFINS = new BaseImpostos
            {
                BASE = Util.FormatoValor(item.Impostos.BASE_PIS, 2),
                TAXVAL = Util.FormatoValor(item.Impostos.CofinsCalculado, 2),
                TAXPAY = Util.FormatoValor(item.Impostos.VALOR_COFINS, 2),
                RATE = Util.FormatoValor(item.Impostos.Aliq_Cofins, 2)
            };
            var impICMS = new BaseImpostos
            {
                BASE = Util.FormatoValor(item.Impostos.BASE_ICMS, 2),
                TAXVAL = Util.FormatoValor(item.Impostos.VALOR_ICMS_CALCULADO, 2),
                TAXPAY = Util.FormatoValor(item.Impostos.VALOR_ICMS, 2),
                RATE = Util.FormatoValor(item.Impostos.ALIQ_ICMS, 2)
            };
            TTAXXml tTAXXml = new TTAXXml
            {
                II = impII,
                IP = impIPI,
                PS = impPIS,
                CF = impCOFINS,
                IC = impICMS
            };
            return tTAXXml;
        }

    }
}
