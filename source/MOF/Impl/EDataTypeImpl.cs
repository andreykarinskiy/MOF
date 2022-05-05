using MOF.ECore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOF.Impl
{
    public class EDataTypeImpl : EClassifierImpl, EDataType
    {
        public bool IsSerializable { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Accept(IEcoreVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
