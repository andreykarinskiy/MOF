using FluentAssertions;
using FluentAssertions.Execution;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MOF.ECore;

namespace MOF.Tests
{
    [TestClass]
    public sealed class EPackageTests : BaseTestFixture
    {
        [TestMethod]
        public void Create_with_params()
        {
            // Arrange
            var parentPackage = Factory.CreateEPackage();
            parentPackage.Name = "ParentPackage";

            // Act
            var sut = Factory.CreateEPackage("Package1", parentPackage);

            // Assert
            using (new AssertionScope())
            {
                sut.ESubpackages.Should().BeEmpty();
                sut.ESuperPackage.Should().Be(parentPackage);
                parentPackage.ESubpackages.Should().Contain(sut);
            }
        }

        [TestMethod]
        public void Can_contain_subpackages()
        {
            // Arrange
            var sut = Factory.CreateEPackage();
            sut.Name = "Super";

            var subPackage = Factory.CreateEPackage();
            subPackage.Name = "Sub";

            // Act
            sut.AddPackage(subPackage);

            // Assert
            sut.ESuperPackage.Should().BeNull();
            sut.ESubpackages.Should().Contain(subPackage);
            subPackage.ESuperPackage.Should().Be(sut);
        }

        [TestMethod]
        public void Package_can_contain_classes()
        {
            Assert.Inconclusive();
        }
    }
}
