using FluentAssertions;
using FluentAssertions.Execution;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MOF.ECore;
using System;

namespace MOF.Tests
{
    [TestClass]
    public sealed class EAnnotationTests : BaseTestFixture
    {
        [TestMethod]
        public void Create_with_params()
        {
            // Arrange
            var dummy = new DummyObject();

            // Act
            var annotation = Factory.CreateEAnnotation("Dummy annotation", dummy);

            // Assert

            using (new AssertionScope())
            {
                annotation.Source.Should().Be("Dummy annotation");
                annotation.EModelElement.Should().Be(dummy);
                dummy.EAnnotations.Should().Contain(annotation);
            }
        }
    }
}
