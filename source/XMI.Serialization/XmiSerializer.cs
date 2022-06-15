using System.Xml;

namespace XMI.Serialization
{
    public class XmiSerializer : IXmiVisitor
    {
        private readonly XmlWriter writer;

        private string xmiVersion = "2.1";
        
        public XmiSerializer(XmlWriter writer)
        {
            this.writer = writer;
        }

        public void Visit(XMI element)
        {
            writer.WriteStartElement("XMI");

            writer.WriteAttributeString("xmlns", "xmi", null, $"http://schema.omg.org/spec/XMI/{xmiVersion}"); // Откуда брать алиасы?'
            writer.WriteAttributeString("xmlns", "UML", null, $"http://schema.omg.org/spec/UML/{xmiVersion}");

            writer.WriteAttributeString("xmi", "version", null, xmiVersion);

            Visit(element.Documentation);

            Visit(element.Difference);

            Visit(element.Extension);

            writer.WriteEndElement();

            writer.Flush();
        }

        public void Visit(Documentation element)
        {
            if (element == null)
            {
                return;
            }

            writer.WriteStartElement("xmi", "Documentation", null);

            writer.WriteAttributeString("exporter", element.Exporter);
            writer.WriteAttributeString("exporterVersion", element.ExporterVersion);
            writer.WriteAttributeString("exporterID", element.ExporterID);
            //writer.WriteAttributeString("timestamp", element.Timestamp.ToString());
            // TODO реализовать сериализацию всех остальных атрибутов!

            writer.WriteEndElement();
        }

        public void Visit(Extension element)
        {
            writer.WriteStartElement("xmi", "Extension", null);

            writer.WriteAttributeString("extender", element.Extender);

            writer.WriteEndElement();
        }

        public void Visit(Difference element)
        {
            throw new NotImplementedException();
        }

        public void Visit(Add element)
        {
            throw new NotImplementedException();
        }

        public void Visit(Replace element)
        {
            throw new NotImplementedException();
        }

        public void Visit(Delete element)
        {
            throw new NotImplementedException();
        }

        private void Visit(IEnumerable<IVisitable> elements)
        {
            if (elements == null)
            {
                return;
            }    

            foreach (var element in elements)
            {
                element.Accept(this);
            }
        }
    }
}
