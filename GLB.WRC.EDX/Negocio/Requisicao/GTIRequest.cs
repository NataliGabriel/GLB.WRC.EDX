using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml;
using GLB.WRC.EDX.ModeloXml;

namespace GLB.WRC.EDX.Negocio.Requisicao
{
    public static class GTIRequest
    {
        public static XDocument FazerRequestServico(EDXXML xmlRaiz)
        {
            //string endereco = @"https://edxnet.e-it.net/edxqas/wbsedx.asmx";
            string endereco = @"https://edxnet.e-it.net/edxqas/wbsedx.asmx";
            string acao = @"http://en.wikipedia.org/wiki/Tempuri/funcsync";
            string nomeArquivo = DateTime.Now.ToString().Replace("/", "").Replace(":", "").Replace(" ", "") + ".xml";
            Type[] tipo = new Type[] { xmlRaiz.REQUEST.CorpoAcao.GetType() };
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(EDXXML), tipo);
            XmlDocument doc = new XmlDocument();
            StreamWriter writer = new StreamWriter(nomeArquivo);
            xmlSerializer.Serialize(writer, xmlRaiz);
            writer.Close(); 
            doc.Load(nomeArquivo);
            doc.ChildNodes[1].Attributes.Remove(doc.ChildNodes[1].Attributes["xmlns:xsi"]);
            doc.ChildNodes[1].Attributes.Remove(doc.ChildNodes[1].Attributes["xmlns:xsd"]);
            XDocument x = new XDocument();
            x = XMLSoap.EnvelopeXml(doc);

            x.Save(nomeArquivo);
            doc.Load(nomeArquivo);

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls13;
            ServicePointManager.ServerCertificateValidationCallback +=
                delegate (
                    Object sender1,
                    X509Certificate certificate,
                    X509Chain chain,
                    SslPolicyErrors sslPolicyErrors)
                {
                    return true;
                };
            HttpWebRequest httpWebRequest = CreateWebRequest(endereco, acao);
            InsertSoapEnvelopeIntoWebRequest(doc, httpWebRequest);
            WebResponse response = httpWebRequest.GetResponse();
            Stream responseStream = response.GetResponseStream();
            XDocument r = new XDocument();
            r = XDocument.Load(responseStream);
            //File.Delete(nomeArquivo);
            return r;
        }
        private static HttpWebRequest CreateWebRequest(string url, string action)
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.ContentType = "text/xml";
            webRequest.Method = "POST";
            return webRequest;
        }


        private static void InsertSoapEnvelopeIntoWebRequest(XmlDocument soapEnvelopeXml, HttpWebRequest webRequest)
        {
            using (Stream stream = webRequest.GetRequestStream())
            {
                soapEnvelopeXml.Save(stream);
            }
        }
    }
}
