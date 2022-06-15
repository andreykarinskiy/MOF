using FluentAssertions;
using FluentAssertions.Execution;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MOF.Common;
using MOF.ECore;

namespace MOF.Tests
{
    [TestClass]
    public sealed class EClassTests : ElementTestFixture<EClass, EClassBuilder>
    {
        private readonly EPackage ownerPackage;

        public EClassTests()
        {
            ownerPackage = eFactory.CreateEPackage();
            ownerPackage.Name = "OwnerPackage";
        }

        [TestMethod]
        public void Build_new_EClass()
        {
            // Arrange, Act
            var sut = builder
                .Owner(ownerPackage)
                .Named("NewClass")
                .Build();

            // Assert
            using (new AssertionScope())
            {
                sut.Name.Should().Be("NewClass");
                // TODO sut.EContainer.Should().Be(ownerPackage);
                sut.EPackage.Should().Be(ownerPackage);
                ownerPackage.EClassifiers.Should().Contain(sut);
            }
        }

        [TestMethod]
        public void Add_comment_to_EClass()
        {
            // Arrange, Act
            var sut = builder
                .Documentation("this is new class")
                .Build();

            // Assert
            sut.EAnnotations[0].Details["documentation"].Should().Be("this is new class");
        }

        [TestMethod]
        public void Add_attributes_to_EClass()
        {
            // Arrange
            // Act
            // Assert
            Assert.Inconclusive();
        }

        [TestMethod]
        public void Set_class_ancestor()
        {
            // Arrange
            var ancestor = eFactory.CreateEClass();

            // Act
            var sut = builder
                .Inherits(ancestor)
                .Build();

            // Assert
            sut.ESuperTypes.Should().Contain(ancestor);
        }

        [TestMethod]
        public void Mark_class_as_abstract()
        {
            // Arrange
            // Act
            var sut = builder
                .IsAbstract(true)
                .Build();

            // Assert
            sut.IsAbstract.Should().Be(true);
        }
    }
}
