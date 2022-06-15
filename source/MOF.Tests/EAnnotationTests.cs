using FluentAssertions;
using FluentAssertions.Execution;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MOF.Common;
using MOF.ECore;

namespace MOF.Tests
{
    [TestClass]
    public sealed class EAnnotationTests : ElementTestFixture<EAnnotation, EAnnotationBuilder>
    {
        [TestMethod]
        public void Build_new_EAnnotation()
        {
            // Arrange
            var target = new DummyObject();

            // Act
            var sut = builder
                .ToElement(target)
                .Source("any-source")
                .AddDetail("any-key", "any-value")
                .Build();

            // Assert
            using (new AssertionScope())
            {
                sut.Source.Should().Be("any-source");
                sut.Details["any-key"].Should().Be("any-value");

                sut.EModelElement.Should().Be(target);
                target.EAnnotations.Should().Contain(sut);
            }
        }

        [TestMethod]
        public void Add_comment_or_documentation_to_Element()
        {
            // Arrange
            var target = new DummyObject();

            // Act
            var sut = builder
                .ToElement(target)
                .AddDocumentation("Comments about the element.")
                .Build();

            // Assert
            sut.Details["documentation"].Should().Be("Comments about the element.");
        }
    }
}
