using MOF.ECore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOF.Impl
{
    public sealed class EGenericTypeImpl : EObjectImpl, EGenericType
    {
        public EGenericType EUpperBound { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IList<EGenericType> ETypeArguments => throw new NotImplementedException();

        public EClassifier ERawType => throw new NotImplementedException();

        public EGenericType ELowerBound { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ETypeParameter ETypeParameter { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public EClassifier EClassifier { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool IsInstance(object instance)
        {
            throw new NotImplementedException();
        }
    }
}
