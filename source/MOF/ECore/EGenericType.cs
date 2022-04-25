using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOF.ECore
{
    public interface EGenericType : EObject
    {
        EGenericType EUpperBound { get; set; }

        IList<EGenericType> ETypeArguments { get; }

        EClassifier ERawType { get; }

        EGenericType ELowerBound { get; set; }

        ETypeParameter ETypeParameter { get; set; }

        EClassifier EClassifier { get; set; }

        bool IsInstance(object instance);
    }
}
