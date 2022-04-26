using MOF.ECore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOF.Impl
{
    public sealed class EOperationImpl : ETypedElementImpl, EOperation
    {
        public EClass EContainingClass => throw new NotImplementedException();

        public IList<EParameter> EParameters => throw new NotImplementedException();

        public IList<EClassifier> EExceptions => throw new NotImplementedException();

        public IList<EGenericType> EGenericExceptions => throw new NotImplementedException();

        public int OperationID => throw new NotImplementedException();

        public IList<ETypeParameter> ETypeParameters => throw new NotImplementedException();

        public bool IsOverrideOf(EOperation someOperation)
        {
            throw new NotImplementedException();
        }
    }
}
