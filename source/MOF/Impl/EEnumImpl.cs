using MOF.ECore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOF.Impl
{
    public sealed class EEnumImpl : EDataTypeImpl, EEnum
    {
        public IList<EEnumLiteral> ELiterals => throw new NotImplementedException();

        public EEnumLiteral GetEEnumLiteral(string name)
        {
            throw new NotImplementedException();
        }

        public EEnumLiteral GetEEnumLiteral(int value)
        {
            throw new NotImplementedException();
        }

        public EEnumLiteral GetEEnumLiteralByLiteral(string literal)
        {
            throw new NotImplementedException();
        }
    }
}
