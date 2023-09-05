using GLB.WRC.EDX.ModeloXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace GLB.WRC.EDX.Negocio.Requisicao
{
    public static class EnviarRequest
    {
        public static XMLRetorno GerarEEnviarXML (IEdxCorpo edxCorpo, string acao)
        {
            EDXXML edx = new EDXXML();
            edx.REQUEST.CorpoAcao = edxCorpo;
            edx.REQUEST.ACAO = acao;
            XDocument documentoXml = new XDocument();
            documentoXml = GTIRequest.FazerRequestServico(edx);
            XMLRetorno xmlRetorno = new XMLRetorno();
            XNamespace xns = XNamespace.Get(@"http://schemas.xmlsoap.org/soap/envelope/");
            string soapBody = documentoXml.Descendants(xns + "Body").First().Descendants().First().Value;
            StringReader sr = new StringReader(soapBody);
            XmlSerializer xs = new XmlSerializer(typeof(XMLRetorno));
            xmlRetorno = (XMLRetorno)xs.Deserialize(sr);
            return xmlRetorno;
        }
    }
}
