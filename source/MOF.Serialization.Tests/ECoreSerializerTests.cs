using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MOF.ECore;
using MOF.Impl;
using System;
using System.IO;
using System.Xml;
using XMI.Serialization.Tests;

namespace MOF.Serialization.Tests
{
    [TestClass]
    public sealed class ECoreSerializerTests
    {
        private readonly IEcoreVisitor sut;
        private readonly EFactory factory;
        private readonly ReaderAdapter reader;

        public ECoreSerializerTests()
        {
            var stream = new MemoryStream();
            var writer = XmlWriter.Create(stream);
            reader = new ReaderAdapter(stream, writer);

            sut = new ECoreSerializer(writer);
            factory = new DefaultEFactory();
        }

        [TestMethod]
        public void Serialize_EPackage()
        {
            // Arrange
            var element = factory.CreateEPackage();
            element.Name = "model";

            // Act
            element.Accept(sut);

            // Assert
            AssertSerializedElementIs(@"
                <ecore:EPackage xmi:version='2.0' 
                                xmlns:xmi='http://www.omg.org/XMI' 
                                xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance'
                                xmlns:ecore='http://www.eclipse.org/emf/2002/Ecore' 
                                nsURI='http://www.eclipse.org/emf/2002/Ecore' 
                                nsPrefix='ecore'
                                name='model'/>");
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
