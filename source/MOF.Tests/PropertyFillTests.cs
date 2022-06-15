using AutoBogus;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MOF.ECore;
using MOF.Impl;
using System;
using System.Reflection;

namespace MOF.Tests
{
    [TestClass]
    public sealed class PropertyFillTests
    {
        [Ignore("Defer until full implementation.")]
        [DataTestMethod]
        [DataRow(typeof(EAnnotationImpl))]
        [DataRow(typeof(EAttributeImpl))]
        [DataRow(typeof(EClassImpl))]
        [DataRow(typeof(EDataTypeImpl))]
        [DataRow(typeof(EEnumImpl))]
        [DataRow(typeof(EEnumLiteralImpl))]
        [DataRow(typeof(EGenericTypeImpl))]
        [DataRow(typeof(EOperationImpl))]
        [DataRow(typeof(EPackageImpl))]
        [DataRow(typeof(EParameterImpl))]
        [DataRow(typeof(EReferenceImpl))]
        [DataRow(typeof(ETypeParameterImpl))]
        public void Fill_EAnnotation_properties(Type elementType)
        {
            // Arrange, Act
            var sut = CreateAndFillElement(elementType);

            // Assert
            sut.Should().NotBeNull();
        }

        private static EObject CreateAndFillElement(Type elementType)
        {
            var factoryMethod = typeof(AutoFaker).GetMethod("Generate", BindingFlags.Public | BindingFlags.Static, new Type[] { typeof(Action<IAutoGenerateConfigBuilder>) });
            var genericMethod = factoryMethod!.MakeGenericMethod(elementType);

#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            return (EObject) genericMethod.Invoke(null, new object[] { null })!;
#pragma warning restore CS8625
        }
    }
}
