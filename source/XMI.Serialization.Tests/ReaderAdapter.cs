using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace XMI.Serialization.Tests
{
    internal sealed class ReaderAdapter
    {
        private readonly MemoryStream stream;
        private readonly XmlWriter writer;

        public ReaderAdapter(MemoryStream stream, XmlWriter writer)
        {
            this.stream = stream;
            this.writer = writer;
        }

        public XElement AsXml()
        {
            stream.Seek(0, SeekOrigin.Begin);
            var element = XElement.Load(stream);
            return Normalize(element);
        }

        public XElement Parse(string xmlText)
        {
            return Normalize(XElement.Parse(xmlText));
        }

        public static XElement Normalize(XElement element)
        {
            if (element.HasElements)
            {
                return new XElement(element.Name, element
                    .Attributes()
                    .Where(a => a.Name.Namespace == XNamespace.Xmlns)
                    .OrderBy(a => a.Name.ToString()), element.Elements().OrderBy(a => a.Name.ToString())
                    .Select(e => Normalize(e)));
            }

            if (element.IsEmpty || string.IsNullOrEmpty(element.Value))
            {
                return new XElement(element.Name, element
                    .Attributes()
                    .OrderBy(a => a.Name.ToString()));
            }

            return new XElement(element.Name, element
                .Attributes()
                .OrderBy(a => a.Name.ToString()), element.Value);
        }
    }
}
