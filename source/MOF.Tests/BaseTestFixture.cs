using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MOF.ECore;
using MOF.Impl;
using System;

namespace MOF.Tests
{
    public abstract class BaseTestFixture
    {
        public BaseTestFixture()
        {
            Factory = new DefaultEFactory();
        }

        protected EFactory Factory { get; }
    }

    public abstract class BaseTestFixture<TElement> : BaseTestFixture where TElement : EObject
    {
        protected TElement SUT { get; set; }

        protected abstract Func<EFactory, TElement> FactoryDelegate { get; }

        [TestInitialize]
        public void Initialize()
        {
            SUT = FactoryDelegate(Factory);
        }

        [TestMethod]
        public void Create_new()
        {           
            SUT.Should().NotBeNull();
        }
    }
}
