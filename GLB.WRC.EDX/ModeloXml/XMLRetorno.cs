using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLB.WRC.EDX.ModeloXml
{
    public class XMLRetorno
    {
        public XMLRetorno()
        {
            EDX = new EDXRetorno();
        }
        public EDXRetorno EDX { get; set; }
    }
    public class EDXRetorno
    {
        public EDXRetorno()
        {
            RESPONSE = new RESPONSERetorno();
        }
        public RESPONSERetorno RESPONSE { get; set; }
    }
    public class RESPONSERetorno
    {
        public RESPONSERetorno()
        {
            STATUS = new STATUSRetorno();
        }
        public STATUSRetorno STATUS { get; set; }
    }
    public class STATUSRetorno
    {
        public string CODE { get; set; }
        public string DESC { get; set; }
    }
}
