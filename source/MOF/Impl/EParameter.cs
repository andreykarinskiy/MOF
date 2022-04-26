using MOF.ECore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOF.Impl
{
    public sealed class EParameterImpl : ETypedElementImpl, EParameter
    {
        public EOperation EOperation => throw new NotImplementedException();
    }
}
