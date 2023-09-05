using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;

namespace GLB.WRC.EDX.Negocio
{
    public static class XMLSoap
    {
        public static XDocument EnvelopeXml(XmlDocument xml)
        {
            XNamespace ns = @"http://schemas.xmlsoap.org/soap/envelope/";
            XNamespace tem = @"http://en.wikipedia.org/wiki/Tempuri/";
            XCData cdata = new XCData(xml.InnerXml);

            XElement root = new XElement(ns + "Envelope",
                new XAttribute(XNamespace.Xmlns + "soapenv", ns),
                new XAttribute(XNamespace.Xmlns + "tem", tem),
                new XElement(ns + "Header", ""),
                new XElement(ns + "Body",
                    new XElement(tem + "funcsync",
                //new XElement(tem + "pXMLRequest", @xml.InnerXml.ToString())))
                new XElement(tem + "pXMLRequest", cdata)))

                );
            XDocument novo = new XDocument();
            // xml.CreateCDataSection(xml.InnerXml);
            novo.Add(root);
            return novo;


        }
    }
}
