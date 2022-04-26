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
    }
}
