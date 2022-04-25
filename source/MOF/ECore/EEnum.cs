using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOF.ECore
{
    public interface EEnum : EDataType
    {
        IList<EEnumLiteral> ELiterals { get; }

        EEnumLiteral GetEEnumLiteral(string name);

        EEnumLiteral GetEEnumLiteral(int value);

        EEnumLiteral GetEEnumLiteralByLiteral(string literal);
    }
}
