using MOF.ECore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOF.Impl
{
    public sealed class EEnumLiteralImpl : ENamedElementImpl, EEnumLiteral
    {
        public int Value { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Literal { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public EEnum EEnum => throw new NotImplementedException();

        public override void Accept(IEcoreVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
