using MOF.ECore;
using System.Xml;

namespace MOF.Serialization
{
    public class ECoreSerializer : IEcoreVisitor
    {
        private readonly XmlWriter writer;

        public ECoreSerializer(XmlWriter writer)
        {
            this.writer = writer;
        }

        public void Visit(EObject element)
        {
            throw new NotImplementedException();
        }

        public void Visit(EAnnotation element)
        {
            throw new NotImplementedException();
        }

        public void Visit(EAttribute element)
        {
            throw new NotImplementedException();
        }

        public void Visit(EClass element)
        {
            throw new NotImplementedException();
        }

        public void Visit(EDataType element)
        {
            throw new NotImplementedException();
        }

        public void Visit(EEnum element)
        {
            throw new NotImplementedException();
        }

        public void Visit(EEnumLiteral element)
        {
            throw new NotImplementedException();
        }

        public void Visit(EGenericType element)
        {
            throw new NotImplementedException();
        }

        public void Visit(EOperation element)
        {
            throw new NotImplementedException();
        }

        public void Visit(EPackage element)
        {
            writer.WriteStartElement("ecore", "EPackage", "http://www.eclipse.org/emf/2002/Ecore");

            writer.WriteAttributeString("xmlns", "ecore", null, "http://www.eclipse.org/emf/2002/Ecore");
            writer.WriteAttributeString("xmlns", "xmi", null, "http://www.omg.org/XMI");
            writer.WriteAttributeString("xmlns", "xsi", null, "http://www.w3.org/2001/XMLSchema-instance");
            writer.WriteAttributeString("xmi", "version", null, "2.0");
            
            writer.WriteAttributeString("nsURI", element.NsURI);
            writer.WriteAttributeString("nsPrefix", element.NsPrefix);
            writer.WriteAttributeString("name", element.Name);

            writer.WriteEndElement();
        }

        public void Visit(EParameter element)
        {
            throw new NotImplementedException();
        }

        public void Visit(EReference element)
        {
            throw new NotImplementedException();
        }

        public void Visit(ETypeParameter element)
        {
            throw new NotImplementedException();
        }
    }
}
