using System;
using System.Collections.Generic;
using System.Text;

namespace GLB.WRC.EDX.ModeloXml
{
    public class PCK
    {
        public PCK()
        {
            TXPNS = new List<TXPNSXml>();
        }
        public string SBELN { get; set; }
        public string DOCNR { get; set; }
        public string PCTYP { get; set; }
        public string PARID { get; set; }
        public string BLDAT { get; set; }
        public string XBLNR { get; set; }
        public string ZUONR { get; set; }
        public string BKTXT { get; set; }
        public string SGTXT { get; set; }
        public string ZFBDT { get; set; }
        public string ABLFD { get; set; }
        public string STATU { get; set; }
        public List<TXPNSXml> TXPNS { get; set; }

    }
    public class TXPNSXml
    {
        public string KSCHL { get; set; }
        public string NETWR { get; set; }
        public string UNREALIZED { get; set; }
    }
}
