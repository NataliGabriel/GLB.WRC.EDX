using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace GLB.WRC.EDX.ModeloXml
{
    public class EDXXML
    {
        public EDXXML()
        {
            REQUEST = new REQUESTXml();
            
        }
        [XmlAttribute("EDX")]
        public string EDXValue { get; set; }
        public REQUESTXml REQUEST { get; set; }
    }
    public class REQUESTXml
    {
        public REQUESTXml()
        {
            
            STR = new STRXml();
        }
        [XmlAttribute("Type")]
        public string Type = "S";
        public string ACAO { get; set; }
        public string IDBR = "74288614000157";
        public string IDCL = "12349468000175";
        public string SHKEY = "A1313412341231OP";
        public STRXml STR { get; set; }
        public IEdxCorpo CorpoAcao { get; set; }
    }
    public class STRXml
    {
        [XmlAttribute("Type")]
        public string Type = "S";
        public string XMLVR = "1";
        public string ENVRM = "QAS";
        public string INTNR = "5115";
    }
}
