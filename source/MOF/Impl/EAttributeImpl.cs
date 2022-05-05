using MOF.ECore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOF.Impl
{
    public sealed class EAttributeImpl : EStructuralFeatureImpl, EAttribute
    {
        public EDataType EAttributeType => throw new NotImplementedException();

        public override void Accept(IEcoreVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
