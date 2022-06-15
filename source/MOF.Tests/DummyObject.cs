using MOF.ECore;
using MOF.Impl;
using System;

namespace MOF.Tests
{
    /// <summary>
    /// Dummy object for unit tests.
    /// </summary>
    public sealed class DummyObject : EModelElementImpl
    {
        public override void Accept(IEcoreVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
