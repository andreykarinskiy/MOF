using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOF.ECore
{
    public interface ETypedElement : ENamedElement
    {
        bool IsOrdered { get; set; }

        bool IsUnique { get; set; }

        int LowerBound { get; set; }

        int UpperBound { get; set; }

        bool IsMany { get; }

        bool IsRequired { get; }

        EClassifier EType { get; set; }

        EGenericType EGenericType { get; set; }
    }
}
