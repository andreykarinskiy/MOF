using MOF.ECore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOF.Impl
{
    public abstract class ETypedElementImpl : ENamedElementImpl, ETypedElement
    {
        public bool IsOrdered { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsUnique { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int LowerBound { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int UpperBound { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool IsMany => throw new NotImplementedException();

        public bool IsRequired => throw new NotImplementedException();

        public EClassifier EType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public EGenericType EGenericType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
