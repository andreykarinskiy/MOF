using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MOF.ECore;
using MOF.Impl;
using System;
using System.Reflection;

namespace MOF.Tests
{
    [TestClass]
    public sealed class EFactoryTests
    {
        [DataTestMethod]
        [DataRow(typeof(EAnnotation))]
        [DataRow(typeof(EAttribute))]
        [DataRow(typeof(EClass))]
        [DataRow(typeof(EDataType))]
        [DataRow(typeof(EEnum))]
        [DataRow(typeof(EEnumLiteral))]
        [DataRow(typeof(EGenericType))]
        [DataRow(typeof(EOperation))]
        [DataRow(typeof(EPackage))]
        [DataRow(typeof(EParameter))]
        [DataRow(typeof(EReference))]
        [DataRow(typeof(ETypeParameter))]
        public void Create_all_elements_that_the_factory_knows(Type elementType)
        {
            // Arrange
            var sut = new DefaultEFactory();

            // Act
            var element = CreateElementByType(sut, elementType);

            // Assert
            element.Should().NotBeNull();
        }

        private EObject CreateElementByType(EFactory factory, Type elementType)
        {
            if (!elementType.IsInterface)
            {
                throw new ArgumentException();
            }

            var methodName = $"Create{elementType.Name}";
            var factoryMethods = typeof(EFactory).GetMethod(methodName, BindingFlags.Public | BindingFlags.Instance);

            try
            {
                var result = factoryMethods!.Invoke(factory, new object[] { });

                if (result is EObject element)
                {
                    return element;
                }

                throw new NotSupportedException();
            }
            catch (TargetInvocationException e) when (e.InnerException is NotImplementedException)
            {
                throw e.InnerException;
            }
        }
    }
}
