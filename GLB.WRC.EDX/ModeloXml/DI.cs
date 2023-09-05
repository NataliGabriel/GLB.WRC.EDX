using System;
using System.Collections.Generic;
using System.Text;

namespace GLB.WRC.EDX.ModeloXml
{
    public class DI
    {
        public DI()
        {
            XPNS = new List<XPNSXml>();
            KURDIS = new List<KURDISXml>();
        }
        public string DINUM { get; set; }
        public string IMPTYP { get; set; }
        public string MODDESP { get; set; }
        public string URFDESP { get; set; }
        public string URFENTR { get; set; }
        public string RECALF { get; set; }
        public string INSUR { get; set; }
        public string INSWR { get; set; }
        public string PREPD { get; set; }
        public string COLLEC { get; set; }
        public string PREPWR { get; set; }
        public string LFREIG { get; set; }
        public string LFREWR { get; set; }
        public string KURDI { get; set; }
        public string FRERT { get; set; }
        public string INSRT { get; set; }
        public string CANAL { get; set; }
        public string REFADM { get; set; }
        public string UFDESEMB { get; set; }
        public string TPINTERMD { get; set; }
        public string PERM { get; set; }
        public string DENUM { get; set; }
        public List<XPNSXml> XPNS { get; set; }
        public List<KURDISXml> KURDIS { get; set; }

    }
    public class XPNSXml
    {
        public string KSCHL { get; set; }
        public string NETWR { get; set; }
    }
    public class KURDISXml
    {
        public string WAERS { get; set; }
        public string KURDI { get; set; }

    }
}
