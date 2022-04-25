using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOF.ECore
{
    public interface EEnumLiteral : ENamedElement //, Enumerator
    {
        int Value { get; set; }

        //Enumerator getInstance();

        //void setInstance(Enumerator value);

        string Literal { get; set; }

        EEnum EEnum { get; }
    }
}
