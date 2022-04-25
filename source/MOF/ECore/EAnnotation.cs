using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOF.ECore
{
    public interface EAnnotation : EModelElement
    {
        string Source { get; set; }

        IDictionary<string, string> Details { get; }

        EModelElement EModelElement { get; set; }

        IList<EObject> Contents { get; }

        IList<EObject> References { get; }
    }
}
