using MOF.ECore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOF.Impl
{
    public class ETypeParameterImpl : ENamedElementImpl, ETypeParameter
    {
        public IList<EGenericType> EBounds => throw new NotImplementedException();

        public override void Accept(IEcoreVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
