using MOF.ECore;
using MOF.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOF.Tests
{
    public sealed class DummyObject : EModelElementImpl
    {
        public override void Accept(IEcoreVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
