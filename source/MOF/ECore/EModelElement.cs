using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOF.ECore
{
    public interface EModelElement : EObject
    {
        IList<EAnnotation> EAnnotations { get; }

        EAnnotation GetEAnnotation(string source);
    }
}
