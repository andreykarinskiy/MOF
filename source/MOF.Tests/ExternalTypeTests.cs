using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MOF.Common;
using MOF.ECore;

namespace MOF.Tests
{
    [TestClass]
    public sealed class ExternalTypeTests
    {
        [DataTestMethod]
        [DataRow(nameof(ECorePackage.EBigDecimal))]
        [DataRow(nameof(ECorePackage.EBigInteger))]
        public void Should_contain_all_types(string dataTypeName)
        {
            // Arrange, Act
            var dataType = ExternalType.GetTypeByName(dataTypeName);

            // Assert
            dataType.Name.Should().Be(dataTypeName);
        }
    }
}
