using System;
using System.Collections.Generic;
using System.Text;

namespace GLB.WRC.EDX.ModeloXml
{
    public class SHP
    {
        public SHP()
        {
            MAKTX_TEXT = new MAKTX_TEXTXml();
            NFSK = new NFSKXml();
            TTAX = new TTAXXml();
        }
        public string SBELN { get; set; }
        public string SBELP { get; set; }
        public string XBELN { get; set; }
        public string XBELP { get; set; }
        public string NBELP { get; set; }
        public string XBLNR { get; set; }
        public string KNTTP { get; set; }
        public string EPSTP { get; set; }
        public string MATNR { get; set; }
        public MAKTX_TEXTXml MAKTX_TEXT { get; set; }
        public string MENGEE { get; set; }
        public string NETPR { get; set; }
        public string NETWR { get; set; }
        public string WAERS { get; set; }
        public string PEINH { get; set; }
        public string MEINS { get; set; }
        public string NLADH { get; set; }
        public string NALDA { get; set; }
        public string ALADI { get; set; }
        public string ADICAO { get; set; }
        public string SEQAD { get; set; }
        public string BPRME { get; set; }
        public string J_1BNBM { get; set; }
        public string CHARG { get; set; }
        public string NVE { get; set; }
        public string LGORT { get; set; }
        public string WERKS { get; set; }
        public string EKGRP { get; set; }
        public string NTGEW { get; set; }
        public string BRGEW { get; set; }
        public string NTGCV { get; set; }
        public string BRGCV { get; set; }
        public string GEWEI { get; set; }
        public string VOLUM { get; set; }
        public string VOLCV { get; set; }
        public string VOLEH { get; set; }
        public string MFRNR { get; set; }
        public string LIFNR { get; set; }
        public string ZTERM { get; set; }
        public string INCO1 { get; set; }
        public string LI { get; set; }
        public string LINUM { get; set; }
        public string LIDAT { get; set; }
        public string LIDEF { get; set; }
        public string NDRBCK { get; set; }
        public string DBITM { get; set; }
        public string MENGS { get; set; }
        public string MEIST { get; set; }
        public string NETWR_DRW { get; set; }
        public string MWSKZ { get; set; }
        public string FREE { get; set; }
        public string CONTNUM { get; set; }
        public string ORIG { get; set; }
        public string MDTYP { get; set; }
        public string FIELD1 { get; set; }
        public string FIELD2 { get; set; }
        public string FIELD3 { get; set; }
        public string FIELD4 { get; set; }
        public string CB1 { get; set; }
        public string CB2 { get; set; }
        public string CB3 { get; set; }
        public string CB4 { get; set; }
        public NFSKXml NFSK { get; set; }
        public TTAXXml TTAX { get; set; }


    }
    public class MAKTX_TEXTXml
    {
        public string TEXT { get; set; }
    }
    public class NFSKXml
    {
        public string FOBBRL_VL { get; set; }
        public string NETFRE_VL { get; set; }
        public string NETINS_VL { get; set; }
        public string NETOTH_II_VL { get; set; }
        public string NETOTH_ICMS_VL { get; set; }
        public string NETOTH_VL { get; set; }
        public string CIF_VL { get; set; }

    }
    public class TTAXXml
    {
        public TTAXXml()
        {
            II = new BaseImpostos();
            IP = new BaseImpostos();
            PS = new BaseImpostos();
            CF = new BaseImpostos();
            IC = new BaseImpostos();
        }
        public BaseImpostos II { get; set; }
        public BaseImpostos IP { get; set; }
        public BaseImpostos PS { get; set; }
        public BaseImpostos CF { get; set; }
        public BaseImpostos IC { get; set; }

    }
    public class BaseImpostos
    {
        public string BASE { get; set; }
        public string TAXVAL { get; set; }
        public string TAXPAY { get; set; }
        public string RATE { get; set; }
        public string CSTCD { get; set; }
        public string TXSIT { get; set; }

    }

}
