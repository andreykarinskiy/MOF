using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOF.ECore
{
    public interface EOperation : ETypedElement
    {
        EClass EContainingClass { get; }

        IList<EParameter> EParameters { get; }

        IList<EClassifier> EExceptions { get; }

        IList<EGenericType> EGenericExceptions { get; }

        int OperationID { get; }

        bool IsOverrideOf(EOperation someOperation);

        IList<ETypeParameter> ETypeParameters { get; }
    }
}
