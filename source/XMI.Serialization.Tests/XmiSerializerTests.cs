using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Xml;

namespace XMI.Serialization.Tests
{
    [TestClass]
    public sealed class XmiSerializerTests
    {
        private readonly IXmiVisitor sut;
        private readonly ReaderAdapter reader;

        public XmiSerializerTests()
        {
            var stream = new MemoryStream();
            var writer = XmlWriter.Create(stream);
            reader = new ReaderAdapter(stream, writer);

            sut = new XmiSerializer(writer);
        }

        [TestMethod]
        public void Serialize_XMI_root()
        {
            // Arrange
            var element = new XMI();

            // Act
            element.Accept(sut);

            // Assert
            AssertSerializedElementIs(@"
                <XMI xmi:version='2.1' 
                     xmlns:xmi='http://schema.omg.org/spec/XMI/2.1' 
                     xmlns:UML='http://schema.omg.org/spec/UML/2.1'/>");
        }

        [TestMethod]
        public void Serialize_Documentation()
        {
            // Arrange
            var element = new XMI
            {
                Documentation = new()
                {
                    ExporterID = "123",
                    Exporter = "Bouml",
                    ExporterVersion = "1.0",
                }
            };

            // Act
            element.Accept(sut);

            // Assert
            AssertSerializedElementIs(@"
                <XMI xmi:version='2.1' 
                     xmlns:xmi='http://schema.omg.org/spec/XMI/2.1' 
                     xmlns:UML='http://schema.omg.org/spec/UML/2.1'>
                  <xmi:Documentation exporter='Bouml' exporterID='123' exporterVersion='1.0' />
                </XMI>");
        }

        [TestMethod]
        public void Serialize_Extension()
        {
            // Arrange
            var element = new XMI
            {
                Extension = new[]
                {
                    new Extension { Extender = "1" }
                }
            };

            // Act
            element.Accept(sut);

            // Assert
            AssertSerializedElementIs(@"
                <XMI xmi:version='2.1' 
                     xmlns:xmi='http://schema.omg.org/spec/XMI/2.1' 
                     xmlns:UML='http://schema.omg.org/spec/UML/2.1'>
                  <xmi:Extension extender='1'/>
                </XMI>");
        }

        private void AssertSerializedElementIs(string expected, bool includeXmiHeader = false)
        {
            var expectedXml = includeXmiHeader ? 
                reader.Parse(EmitXmiHeader(expected)) : 
                reader.Parse(expected);

            var actualXml = reader.AsXml();

            Console.WriteLine(expectedXml);
            Console.WriteLine(actualXml);

            actualXml.Should().BeEquivalentTo(expectedXml);
        }

        private string EmitXmiHeader(string expected)
        {
            return @$"
                <XMI xmi:version='2.1' 
                     xmlns:xmi='http://schema.omg.org/spec/XMI/2.1' 
                     xmlns:UML='http://schema.omg.org/spec/UML/2.1'>
                  {expected}
                </XMI>";
        }
    }
}
