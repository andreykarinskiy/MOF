using MOF.ECore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOF.Impl
{
    public sealed class EReferenceImpl : EStructuralFeatureImpl, EReference
    {
        public EClass EReferenceType => throw new NotImplementedException();

        public IList<EAttribute> EKeys => throw new NotImplementedException();

        public bool IsContainer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public EReference EOpposite { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Accept(IEcoreVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
